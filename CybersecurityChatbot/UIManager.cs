using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public static class UIManager
    {
        public static void ShowWelcome()
        {
            Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(AsciiArt.GetLogo());
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + new string('=', 78));
            Console.WriteLine("                     YEMA-CYBER BOT");
            Console.WriteLine(new string('=', 78));
            Console.ResetColor();
            
            Thread.Sleep(800);
        }

        public static void Say(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void Ask(string question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(question);
            Console.ResetColor();
        }

        public static void Type(string message, int speed = 30)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(speed);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void Line()
        {
            Console.WriteLine(new string('─', 78));
        }
        
        public static void Wait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }
    }
}
