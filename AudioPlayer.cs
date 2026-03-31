using System;
using System.Media;
using System.IO;

namespace CybersecurityChatbot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            string soundFile = "greeting.wav";

            if (File.Exists(soundFile))
            {
                try
                {
                    using (SoundPlayer player = new SoundPlayer(soundFile))
                    {
                        player.PlaySync();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Note: Could not play voice greeting.");
                }
            }
            else
            {
                Console.WriteLine("Note: Voice greeting file not found. Text greeting only.");
            }
        }
    }
}