using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    class SynthesizeClass // 合成类
    {
        public string deviceGuid { get; set; }
        public Int64 lastTimestamp { get; set; }
        public Int64 timeStamp { get; set; }
        public List<SoundClass> soundList { get; set; }
    }

    class SoundClass // 声音类
    {
        public Int64 timeStamp { get; set; }
        public int dataLength { get; set; }
        public byte[] soundData { get; set; }
    }

    class SoundListClass
    {
        public string deviceGuid { get; set; }
        public List<byte[]> dataList;
    }

    public struct WaveHeader
    {
        public UInt32 main_chunk;					/* 'RIFF' */
        public UInt32 length;						/* file length */
        public UInt32 chunk_type;					/* 'WAVE' */

        public UInt32 sub_chunk;					/* 'fmt ' */
        public UInt32 format_len;					/* sizeof(PCMWAVEFORMAT) */
        public UInt16 format;						/* format type: such as PCM - 1 for waveform-audio */
        public UInt16 channels;					/* number of channels in the waveform-audio data, 1 Mono, 2 Stereo */
        public UInt32 sample_per_sec;			/* sample rate */
        public UInt32 avg_bytes_per_sec;     /* average bytes per second.
							       Required average data transfer rate, in bytes per second. 
							       For example, 16-bit stereo at 44.1 kHz has an average 
							       data rate of 176,400 bytes per second
							       (sample rate * bits per sample * channels / 8) or 
							       (sample rate * block align) */
        public UInt16 block_align;                 /* block align; 1 or 2 bytes, 
									     The block alignment is the minimum atomic unit of data. 
									     For PCM data, the block alignment is the number of bytes 
									     used by a single sample, including data for both channels
									     if the data is stereo. 
									     For example, the block alignment for 16-bit stereo PCM
									     is 4 bytes (2 channels  — 2 bytes per sample). */
        public UInt16 bits_per_sample;       /* number of bits per sample, such as 8, 12 or 16 bit */

        public UInt32 data_chunk;                  /* 'data' */
        public UInt32 data_length;                  /* sample count */
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct WAVE_Header
    {
        public string RIFF_ID;         //4 byte , 'RIFF'
        public Int32 File_Size;         //4 byte , 文件长度

        public string RIFF_Type;       //4 byte , 'WAVE'

        public string FMT_ID;          //4 byte , 'fmt'
        public Int32 FMT_Size;          //4 byte , 数值为16或18，18则最后又附加信息
        public Int16 FMT_Tag;          //2 byte , 编码方式，一般为0x0001
        public Int16 FMT_Channel;     //2 byte , 声道数目，1--单声道；2--双声道
        public Int32 FMT_SamplesPerSec;//4 byte , 采样频率
        public Int32 AvgBytesPerSec;   //4 byte , 每秒所需字节数,记录每秒的数据量
        public Int16 BlockAlign;      //2 byte , 数据块对齐单位(每个采样需要的字节数)
        public Int16 BitsPerSample;   //2 byte , 每个采样需要的bit数

        public string DATA_ID;         //4 byte , 'data'
        public Int32 DATA_Size;         //4 byte , 

    }
}
