using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public static class UIManager
    {
        public static void DisplayHeader()
        {
            Console.Clear();
            WriteColoredText(AsciiArt.GetLogo(), ConsoleColor.Cyan);
            Thread.Sleep(1000);

            WriteColoredText("\n" + new string('█', 80), ConsoleColor.DarkGreen);
            WriteColoredText("          CYBERSECURITY AWARENESS BOT v1.0", ConsoleColor.Green);
            WriteColoredText(new string('█', 80), ConsoleColor.DarkGreen);
            Thread.Sleep(500);
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

        public static void DisplayBorder(char borderChar, ConsoleColor color)
        {
            WriteColoredText(new string(borderChar, 80), color);
        }

        public static void DisplaySectionHeader(string title)
        {
            WriteColoredText($"\n---- {title} ---", ConsoleColor.Magenta);
        }
    }
}