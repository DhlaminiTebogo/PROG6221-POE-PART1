using System;

public class Bot
{
	public Bot()
	{

         private readonly ResponseEngine _engine = new ResponseEngine();
        private string _userName = "User";

        public void Start()
        {
            ConsoleUI.PrintBanner();
            AudioPlayer.PlayGreeting("greeting.wav");

            ConsoleUI.PrintDivider();
            ConsoleUI.PrintBot("Hello! What is your name?");
            ConsoleUI.PrintUser();

            string name = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(name))
            _userName = name;

            ConsoleUI.PrintDivider();
            ConsoleUI.PrintBot($"Nice to meet you, {_userName}! Type 'help' to see what I can do, or 'bye' to exit.");
            ConsoleUI.PrintDivider();

            while (true)
            {
                Console.WriteLine();
                ConsoleUI.PrintUser();
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    ConsoleUI.PrintError("I didn't understand that. Could you rephrase?");
                    continue;
                }

                string response = _engine.GetResponse(input);

                if (response == "QUIT")
                {
                    ConsoleUI.PrintDivider();
                    ConsoleUI.PrintBot($"Stay safe online, {_userName}! Goodbye!");
                    ConsoleUI.PrintDivider();
                    break;
                }
                else if (response == "")
                {
                    ConsoleUI.PrintError($"I didn't quite understand that, {_userName}. Could you rephrase?");
                }
                else
                {
                    ConsoleUI.PrintBot(response);
                }
            }
        }
}
