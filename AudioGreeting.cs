using System.Media;

namespace Bot;

public static class AudioGreeting
{
    public static void PlayGreeting(string filePath = "AudioGreeting.wav")
    {
        try
        {
            if (File.Exists(filePath))
            {
                using var player = new SoundPlayer(filePath);
                player.PlaySync();
            }
            else
            {
                ConsoleUI.Printinfo("Greeting file not found");
            }

        }
        catch
        {
            ConsoleUI.PrintInfo("Audio playback error");
        }

    }
}

