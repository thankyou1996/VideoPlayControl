Sure, I think it's stable enough now. Atleast it's good enough for the use I intended 

I haven't tested this in anything but WinForms as that is what i need if for.

Here's a download link for the source:
www.mediafire.com/.../VideoEncoderAsync.rar

Changelog:
-Fixed filename with spaces bug
-Fixed deadlock issue with process execution
-Added delegates, events and methods for progress and finish
-Added extra fields in VideoFile for video and audio bitrate, framerate, totalframes
-Added extraction methods for the above
-Added RunProcessAsync
-Added EncodeVideoAsync and EncodeVideoAsyncAutoCommand
-Added encoder threads *read below*

Threads:
Threads in ffmpeg is not straight forward. Some codecs dont support multiple threads. The maximum thread count is not the same for codecs.
Auto thread count can be used passing 0 as parameter, not all codecs support auto thead count.
To disable threads, pass 1 as parameter.

Example usage in WinForms: Add methods Progress and Finish
Encoder enc = new Encoder();
enc.FFmpegPath = "ffmpeg.exe";
VideoFile videoFile = new VideoFile("C:\\some file.avi");
string outputFile = "C:\\output file.wmv";
enc.OnEncodeProgress += new EncodeProgressEventHandler(Progress);
enc.OnEncodeFinished += new EncodeFinishedEventHandler(Finished);
enc.EncodeVideoAsync(videoFile, QuickVideoEncodingCommands.WMVVeryHighQualityKeepOriginalSize, outputFile, this, 1);


Enjoy
Best regards, Anders Tornes