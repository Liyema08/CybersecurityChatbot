using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.SetWindowSize(120, 40);

            // Play voice greeting
            AudioManager.PlayVoiceGreeting();

            // Display ASCII art header
            UIManager.DisplayHeader();

            // Initialize chatbot
            Chatbot chatbot = new Chatbot();
            chatbot.Start();
        }
    }
}