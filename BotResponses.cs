using System;

public class BotResponses
{
	public BotResponses()
	{
        if (string.IsNullOrWhiteSpace(input))
            return null;

        string lower = input.ToLower().Trim();

        if (lower.Contains("how are you"))
            return "I'm fully operational and scanning for threats! Thanks for asking.";

        else if (lower.Contains("help") || lower.Contains("what can i ask"))
            return "You can ask me about:\n  1) Password safety\n  2) Phishing\n  3) Safe browsing";

        else if (lower.Contains("password"))
            return "Use at least 12 characters, mix between letters,numbers and symbols. It is recommended to never reuse passwords.";

        else if (lower.Contains("phishing") || lower.Contains("scam"))
            return "Never click links in unexpected emails. Always verify the sender and go directly to websites instead.";

        else if (lower.Contains("browsing") || lower.Contains("internet"))
            return "Always use HTTPS, avoid public Wi-Fi for sensitive tasks, and keep your browser updated.";

        else if (lower.Contains("bye") || lower.Contains("exit") || lower.Contains("quit"))
            return "QUIT";

        else
            return "";
    }
}
