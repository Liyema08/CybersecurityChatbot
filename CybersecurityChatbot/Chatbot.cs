using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private string userName;
        private ResponseHandler responseHandler;

        public Chatbot()
        {
            responseHandler = new ResponseHandler();
        }

        public void Start()
        {
            UIManager.WriteColoredText("\n" + new string('=', 80), ConsoleColor.Cyan);
            UIManager.WriteColoredText(" CYBERSECURITY AWARENESS BOT INITIALIZED ", ConsoleColor.Green);
            UIManager.WriteColoredText(new string('=', 80), ConsoleColor.Cyan);

            userName = GetValidUserName();
            DisplayPersonalizedGreeting();
            RunConversationLoop();
        }

        private string GetValidUserName()
        {
            string name = "";
            while (string.IsNullOrWhiteSpace(name))
            {
                UIManager.WriteColoredText("\n Please enter your name: ", ConsoleColor.Yellow);
                name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    UIManager.WriteColoredText(" Name cannot be empty. Please try again.", ConsoleColor.Red);
                    Thread.Sleep(1000);
                }
            }
            return name;
        }

        private void DisplayPersonalizedGreeting()
        {
            UIManager.TypingEffect($"\n Hello, {userName}!", 50);
            Thread.Sleep(500);
            UIManager.TypingEffect("\nI'm your Cybersecurity Awareness Bot, here to help you stay safe online!", 40);
            Thread.Sleep(500);
            UIManager.TypingEffect("\n I can help you with:", 50);
            UIManager.WriteColoredText("\n   • Password Safety", ConsoleColor.Magenta);
            UIManager.WriteColoredText("   • Phishing Prevention", ConsoleColor.Magenta);
            UIManager.WriteColoredText("   • Safe Browsing Tips", ConsoleColor.Magenta);
            UIManager.WriteColoredText("   • General Cybersecurity Questions", ConsoleColor.Magenta);
        }

        private void RunConversationLoop()
        {
            bool running = true;

            while (running)
            {
                UIManager.WriteColoredText("\n" + new string('─', 80), ConsoleColor.DarkGray);
                UIManager.WriteColoredText($" {userName}: ", ConsoleColor.Cyan, false);
                string userInput = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    UIManager.WriteColoredText("I didn't catch that. Could you please say something?", ConsoleColor.Yellow);
                    continue;
                }

                if (userInput == "exit" || userInput == "quit" || userInput == "goodbye")
                {
                    UIManager.TypingEffect($"\n Goodbye, {userName}! Stay safe online! ", 50);
                    Thread.Sleep(1000);
                    running = false;
                    continue;
                }

                string response = responseHandler.GetResponse(userInput, userName);
                UIManager.WriteColoredText($"\nYEMA: ", ConsoleColor.Green, false);
                UIManager.TypingEffect(response, 30);
            }
        }
    }
}