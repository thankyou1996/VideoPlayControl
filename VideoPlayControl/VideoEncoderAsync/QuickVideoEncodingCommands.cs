/// 
/// 
/// Ready made encoding commands for FFmpeg
/// Use when calling EncodeVideo commands as string encodingCommand
/// Add remove as you like
/// 
///
///
namespace VideoEncoder
{
    public class QuickVideoEncodingCommands
    {
        //-b
        static string LQVideoBitrate = "256k";
        static string MQVideoBitrate = "512k";
        static string HQVideoBitrate = "756k";
        static string VHQVideoBitrate = "1024k";
        //-ab 
        static string LQAudioBitrate = "32k";
        static string MQAudioBitrate = "64k";
        static string HQAudioBitrate = "96k";
        static string VHQAudioBitrate = "128k";
        //-ar
        static string LQAudioSamplingFrequency = "22050";
        static string MQAudioSamplingFrequency = "44100";
        static string HQAudioSamplingFrequency = "44100";
        //-s
        static string SQCIF = "sqcif"; //128x96
        static string QCIF = "qcif"; //176x144
        static string QVGA = "qvga"; //320x240
        static string CIF = "cif"; //352x288
        static string VGA = "vga"; //640x480
        static string SVGA = "svga"; //800x600

   
        // todo
        //insert logo
        //
        //string LogoPath ="/Path/to/transparent/png";
        //string PositionX ="0";
        //string PositionY ="0";
        //string.Format("-vhook \"vhook/imlib2.dll -x {0} -y {1}  -i {2}\"", PositionX,PositionY,LogoPath);



        //flv
        public static string FLVLowQualityQCIF = string.Format("-y -b {0} -ab {1} -ar {2} -s {3} -f flv", LQVideoBitrate, LQAudioBitrate, LQAudioSamplingFrequency, QVGA);
        public static string FLVMediumQualityCIF = string.Format("-y -b {0} -ab {1} -ar {2} -s {3} -f flv", MQVideoBitrate, MQAudioBitrate, MQAudioSamplingFrequency, CIF);
        public static string FLVHighQualityVGA = string.Format("-y -b {0} -ab {1} -ar {2} -s {3} -f flv", HQVideoBitrate, HQAudioBitrate, HQAudioSamplingFrequency, VGA);
        public static string FLVVeryHighQualitySVGA = string.Format("-y -b {0} -ab {1} -ar {2} -s {3} -f flv", VHQVideoBitrate, VHQAudioBitrate, HQAudioSamplingFrequency, SVGA);

        public static string FLVLowQualityKeepOriginalSize = string.Format("-y -b {0} -ab {1} -ar {2} -f flv", LQVideoBitrate, LQAudioBitrate, LQAudioSamplingFrequency, QVGA);
        public static string FLVMediumQualityKeepOriginalSize = string.Format("-y -b {0} -ab {1} -ar {2} -f flv", MQVideoBitrate, MQAudioBitrate, MQAudioSamplingFrequency, CIF);
        public static string FLVHighQualityKeepOriginalSize = string.Format("-y -b {0} -ab {1} -ar {2} -f flv", HQVideoBitrate, HQAudioBitrate, HQAudioSamplingFrequency, VGA);
        public static string FLVVeryHighQualityKeepOriginalSize = string.Format("-y -b {0} -ab {1} -ar {2} -f flv", VHQVideoBitrate, VHQAudioBitrate, HQAudioSamplingFrequency, SVGA);

        //3gp
        public static string THREEGPLowQualitySQCIF = string.Format("-y -acodec aac -ac 1 -b {0} -ab {1} -ar {2} -s {3} -f 3gp", LQVideoBitrate, LQAudioBitrate, LQAudioSamplingFrequency, SQCIF);
        public static string THREEGPMediumQualityQCIF = string.Format("-y -acodec aac -b {0} -ab {1} -ar {2} -s {3} -f 3gp", MQVideoBitrate, MQAudioBitrate, MQAudioSamplingFrequency, QCIF);
        public static string THREEGPHighQualityCIF = string.Format("-y -acodec aac -b {0} -ab {1} -ar {2} -s {3} -f 3gp", VHQVideoBitrate, VHQAudioBitrate, HQAudioSamplingFrequency, CIF);
        //mp4
        public static string MP4LowQualityKeepOriginalSize = string.Format("-y -b {0} -ab {1} -ar {2} -f mp4", LQVideoBitrate, LQAudioBitrate, LQAudioSamplingFrequency, QVGA);
        public static string MP4MediumQualityKeepOriginalSize = string.Format("-y -b {0} -ab {1} -ar {2} -f mp4", MQVideoBitrate, MQAudioBitrate, MQAudioSamplingFrequency, CIF);
        public static string MP4HighQualityKeepOriginalSize = string.Format("-y -b {0} -ab {1} -ar {2} -f mp4", HQVideoBitrate, HQAudioBitrate, HQAudioSamplingFrequency, VGA);

        public static string MP4LowQualityQVGA = string.Format("-y -b {0} -ab {1} -ar {2} -s {3} -f mp4", LQVideoBitrate, LQAudioBitrate, LQAudioSamplingFrequency, QVGA);
        public static string MP4MediumQualityCIF = string.Format("-y -b {0} -ab {1} -ar {2} -s {3} -f mp4", MQVideoBitrate, MQAudioBitrate, MQAudioSamplingFrequency, CIF);
        public static string MP4HighQualityVGA = string.Format("-y -b {0} -ab {1} -ar {2} -s {3} -f mp4", HQVideoBitrate, HQAudioBitrate, HQAudioSamplingFrequency, VGA);

        //WMV
        public static string WMVLowQualityQVGA = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2} -s {3}", LQVideoBitrate, LQAudioBitrate, LQAudioSamplingFrequency, QVGA);
        public static string WMVMediumQualityCIF = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2} -s {3}", MQVideoBitrate, MQAudioBitrate, MQAudioSamplingFrequency, CIF);
        public static string WMVHighQualityVGA = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2} -s {3}", HQVideoBitrate, HQAudioBitrate, HQAudioSamplingFrequency, VGA);
        public static string WMVVeryHighQualitySVGA = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2} -s {3}", VHQVideoBitrate, VHQAudioBitrate, HQAudioSamplingFrequency, SVGA);

        public static string WMVLowQualityKeepOriginalSize = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2}", LQVideoBitrate, LQAudioBitrate, LQAudioSamplingFrequency, QVGA);
        public static string WMVMediumQualityKeepOriginalSize = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2}", MQVideoBitrate, MQAudioBitrate, MQAudioSamplingFrequency, CIF);
        public static string WMVHighQualityKeepOriginalSize = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2}", HQVideoBitrate, HQAudioBitrate, HQAudioSamplingFrequency, VGA);
        public static string WMVVeryHighQualityKeepOriginalSize = string.Format("-y -vcodec wmv2  -acodec wmav2 -b {0} -ab {1} -ar {2}", VHQVideoBitrate, VHQAudioBitrate, HQAudioSamplingFrequency, SVGA);

        public static string AutoDetect(long videoBitrate) { return string.Format("-y -b {0}", videoBitrate.ToString()); }
    }
}