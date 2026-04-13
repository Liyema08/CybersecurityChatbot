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
            Console.ResetColor();
            Thread.Sleep(1000);
        }

        public static void WriteColoredText(string text, ConsoleColor color, bool newLine = true)
        {
            Console.ForegroundColor = color;
            if (newLine)
                Console.WriteLine(text);
            else
                Console.Write(text);
            Console.ResetColor();
        }

        public static void TypingEffect(string text, int delayMs)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
