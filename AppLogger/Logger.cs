using System;
using Humanizer;

namespace AppLogger
{
    public class Logger
    {
        public static void Log(string text)
        {
            Console.WriteLine(text.Humanize());
        }
    }
}
