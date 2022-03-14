using System;

namespace lesson7
{
    class Programslack
    {
        static void Main()
        {
            var converter = new VideoConverter();
            converter.OnVideoConverted += VideoConverted;
            var result = converter.Convert("Squid Games");

            result.Wait();
        }
        private static void VideoConverted(string title)
        {
            Console.WriteLine($"{title}");
        }
    }
}
