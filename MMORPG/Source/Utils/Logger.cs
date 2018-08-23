using MMORPG.Source.Common;
using System;

namespace MMORPG.Source.Utils
{
    public class Logger : SingletonThreaded<Logger>
    {
        public void Init()
        {

        }

        public void Log(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void Info(string message)
        {
            Log(message, ConsoleColor.DarkGreen);
        }

        public void Normal(string message)
        {
            Log(message, ConsoleColor.White);
        }

        public void Warning(string message)
        {
            Log(message, ConsoleColor.Yellow);
        }

        public void Error(string message)
        {
            Log(message, ConsoleColor.Red);
        }

        public void Debug(string message)
        {
            Log(message, ConsoleColor.White);
        }
    }
}
