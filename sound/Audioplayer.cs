using System;
using System.Media;
using System.IO;

namespace CyberBotSA
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

                if (File.Exists(audioPath))
                {
                    SoundPlayer player = new SoundPlayer(audioPath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("[Voice greeting file not found]");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Could not play audio: {ex.Message}]");
            }
        }
    }
}
