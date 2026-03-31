using System;

public class ConsoleUIMethods
{
	public ConsoleUIMethods()
	{

        public static void PrintBanner()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("============================================");
        Console.WriteLine(@"
    ___      _               _           _   
   / __\   _| |__   ___ _ __| |__   ___ | |_ 
  / /| | | | '_ \ / _ \ '__| '_ \ / _ \| __|
 / /_| |_| | |_) |  __/ |  | |_) | (_) | |_ 
/____/\__, |_.__/ \___|_|  |_.__/ \___/ \__|
      |___/                                  
        ");
        Console.WriteLine("============================================");
        Console.ResetColor();
    }

    public static void PrintBot(string message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Bot: ");
        Console.ResetColor();
        Console.WriteLine(message);
    }

    public static void PrintUser()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("You: ");
        Console.ResetColor();
    }

    public static void PrintError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public static void PrintDivider()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("--------------------------------------------");
        Console.ResetColor();
    }
}
}
