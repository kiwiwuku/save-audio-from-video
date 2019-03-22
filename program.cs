using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFMpegSharp;
using FFMpegSharp.FFMPEG;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputVideoFile = "D:/test/witch.mp4",
      outputAudioFile = "D:/test/witch.mp3";
            new FFMpeg()
                .ExtractAudio(
                    VideoInfo.FromPath(inputVideoFile),
                    new FileInfo(outputAudioFile)
                );
        }
    }
}
