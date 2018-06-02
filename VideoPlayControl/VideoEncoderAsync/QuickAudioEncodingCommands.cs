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
    public class QuickAudioEncodingCommands
    {
        //mp3
        public static string MP3128Kbps = "-y -ab 128k -ar 44100";
        public static string MP396Kbps = "-y -ab 96k -ar 44100";
        public static string MP364Kbps = "-y -ab 64k -ar 44100";
        public static string MP332Kbps = "-y -ab 32k -ar 44100";
    }
}