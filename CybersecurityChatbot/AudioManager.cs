using System;
using System.Media;
using System.IO;
using System.Threading;

namespace CybersecurityChatbot
{
    public static class AudioManager
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

                if (File.Exists(audioPath))
                {
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync();
                    }
                }
                else
                {
                    // Fallback beep pattern
                    Console.Beep(440, 500);
                    Thread.Sleep(100);
                    Console.Beep(440, 500);
                    Thread.Sleep(100);
                    Console.Beep(440, 500);
                    Thread.Sleep(300);
                    Console.Beep(523, 500);
                }
            }
            catch (Exception)
            {
                // Silent fail - continue without audio
            }
        }
    }
}