using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "YEMA-CYBER Bot";
            Console.SetWindowSize(120, 40);
            
            AudioManager.PlayVoiceGreeting();
            UIManager.ShowWelcome();
            
            Chatbot chatbot = new Chatbot();
            chatbot.Start();
        }
    }
}
