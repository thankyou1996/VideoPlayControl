using AxisMediaParserLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoPlayback
{
    class AmpFileSample
    {
        public long FilePosition;
        public int SampleType;
        public int SampleFlags;
        public ulong StartTime;
        public ulong StopTime;
        public int BufferSize;

        public byte[] Buffer;
    }

    class SeekPosition
    {
        public SeekPosition(ulong mediaPosition, long filePosition)
        {
            this.mediaPosition = mediaPosition;
            this.filePosition = filePosition;
        }

        public ulong mediaPosition;
        public long filePosition;
    }

    /// <summary>
    /// Parse AXIS Media Parser internal binary format
    /// </summary>
    class VideoBackPlay_AmpFileParser
    {
        public static readonly Guid MEDIATYPE_Video = new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Audio = new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MEDIATYPE_Onvif_Metadata = new Guid(0xd607a0e7, 0xbe64, 0x4869, 0xb7, 0xd, 0x46, 0xf2, 0xe0, 0x5d, 0x66, 0xd0);

        private FileStream inFileStream;
        private BinaryReader reader;

        // lists all sync points in file in reverse order
        List<SeekPosition> seekHead;

        public VideoBackPlay_AmpFileParser(string filePath)
        {
            inFileStream = new FileStream(filePath, FileMode.Open);
            reader = new BinaryReader(inFileStream);

            Analyse();
            SeekToPrevSyncPoint(0);
        }

        public byte[] MediaTypeBuffer { get; private set; }

        public long StartTime { get; private set; }

        public long Duration { get; private set; }

        public bool IsVideo { get; private set; }

        public bool IsAudio { get; private set; }

        public bool IsMetadata { get; private set; }

        public void Close()
        {
            inFileStream.Close();

            reader = null;
            inFileStream = null;
        }

        public AmpFileSample ReadSample()
        {
            AmpFileSample sample = null;
            try
            {
                sample = ReadHeader();
                if (sample != null)
                {
                    sample.Buffer = reader.ReadBytes(sample.BufferSize);
                }
            }
            catch (EndOfStreamException) { }

            return sample;
        }
        /// <summary>
        /// Sets the file position to the video sync-point prior to the requested media position.
        /// </summary>
        /// <param name="mediaPosition">
        /// The requested media position in the file. This value will be corrected so that it
        /// reflects the exact media position of the nearest video frame.
        /// </param>
        public void Seek(ref long mediaPosition)
        {
            SeekToPrevSyncPoint(mediaPosition);

            long syncPointFilePosition = reader.BaseStream.Position;

            // find the exact media position of the nearest video frame
            AmpFileSample sample;
            long lastVideoFrameTime = StartTime;
            while (true)
            {
                try
                {
                    sample = ReadHeader();
                    if (sample == null)
                    {
                        break;
                    }

                    if ((long)sample.StartTime > mediaPosition) //大于当前播放时间
                    {
                        //返回当前
                        mediaPosition = lastVideoFrameTime;
                        break;
                    }

                    reader.BaseStream.Seek(sample.BufferSize, SeekOrigin.Current);

                    if (IsVideoSampleType(sample.SampleType))
                    {
                        lastVideoFrameTime = (long)sample.StartTime;
                    }
                }
                catch (EndOfStreamException)
                {
                    // end-of-stream reached
                    break;
                }
            }


            // set file position to sync-point
            reader.BaseStream.Position = syncPointFilePosition;

        }

        private void SeekToPrevSyncPoint(long mediaPosition)
        {
            // seek index is in reverse order
            if (mediaPosition <= (long)seekHead[seekHead.Count - 1].mediaPosition)
            {
                reader.BaseStream.Seek(seekHead[seekHead.Count - 1].filePosition, SeekOrigin.Begin);
                return;
            }

            foreach (SeekPosition seekPosition in seekHead)
            {
                if (mediaPosition >= (long)seekPosition.mediaPosition)
                {
                    reader.BaseStream.Seek(seekPosition.filePosition, SeekOrigin.Begin);
                    break;
                }
            }
        }

        private AmpFileSample ReadHeader()
        {
            if (reader.BaseStream.Position >= reader.BaseStream.Length)
            {
                return null;
            }

            AmpFileSample sample = new AmpFileSample();

            sample.FilePosition = reader.BaseStream.Position;

            sample.SampleType = reader.ReadInt32();
            sample.SampleFlags = reader.ReadInt32();
            sample.StartTime = reader.ReadUInt64();
            sample.StopTime = reader.ReadUInt64();
            sample.BufferSize = reader.ReadInt32();

            return sample;
        }

        private void Analyse()
        {
            ulong firstTime = UInt64.MaxValue;
            ulong lastTime = UInt64.MinValue;

            Duration = 0;
            seekHead = new List<SeekPosition>();

            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            // media type information
            int mediaTypeBufferSize = reader.ReadInt32();
            this.MediaTypeBuffer = reader.ReadBytes(mediaTypeBufferSize);

            // check media types
            IsVideo = ContainBytePattern(MediaTypeBuffer, MEDIATYPE_Video.ToByteArray());
            IsAudio = ContainBytePattern(MediaTypeBuffer, MEDIATYPE_Audio.ToByteArray());
            IsMetadata = ContainBytePattern(MediaTypeBuffer, MEDIATYPE_Onvif_Metadata.ToByteArray());

            seekHead.Add(new SeekPosition(0, reader.BaseStream.Position));

            AmpFileSample sample;
            while (true)
            {
                try
                {
                    // Read frame data
                    sample = ReadHeader();
                    if (sample == null)
                    {
                        break;
                    }

                    reader.BaseStream.Seek(sample.BufferSize, SeekOrigin.Current);

                    if (IsVideoSampleType(sample.SampleType) &&
                            (sample.SampleFlags & (long)AMP_SAMPLE.AMP_S_SYNCPOINT) > 0)
                    {
                        seekHead.Add(new SeekPosition(sample.StartTime, sample.FilePosition));
                    }

                    if (sample.StartTime > lastTime && IsVideoSampleType(sample.SampleType))
                    {
                        lastTime = sample.StartTime;
                    }

                    if (sample.StartTime < firstTime && IsVideoSampleType(sample.SampleType))
                    {
                        firstTime = sample.StartTime;
                    }
                }
                catch (EndOfStreamException)
                {
                    // end-of-stream reached
                    break;
                }
            }

            seekHead.Reverse();
            StartTime = (long)firstTime;
            Duration = (long)(lastTime - firstTime);
        }

        static public bool ContainBytePattern(byte[] bytes, byte[] pattern)
        {
            List<int> positions = new List<int>();
            int patternLength = pattern.Length;
            int totalLength = bytes.Length;
            byte firstMatchByte = pattern[0];
            for (int i = 0; i < totalLength; i++)
            {
                if (firstMatchByte == bytes[i] && totalLength - i >= patternLength)
                {
                    bool isMatch = true;
                    for (int j = 1; j < patternLength; j++)
                    {
                        if (bytes[i + j] != pattern[j])
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool IsVideoSampleType(long sampleType)
        {
            if (sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_CONFIG ||
            sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_IVOP ||
            sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_BVOP ||
            sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MPEG4_VIDEO_FRAGMENT ||
            sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_MJPEG_VIDEO ||
            sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_H264_VIDEO_CONFIG ||
            sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_H264_VIDEO_IDR ||
            sampleType == (long)AMP_VIDEO_SAMPLE_TYPE.AMP_VST_H264_VIDEO_NON_IDR)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
