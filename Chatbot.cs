using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private string userName;

        public void Start()
        {
            // Show ASCII art
            UIManager.ShowAsciiArt();

            // Play voice greeting
            AudioPlayer.PlayGreeting();

            // Get user name
            Console.Write("What's your name? ");
            userName = Console.ReadLine();

            // Check if name is empty
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Name cannot be empty!");
                Console.ResetColor();
                Console.Write("What's your name? ");
                userName = Console.ReadLine();
            }

            // Welcome message
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello, {userName}! Welcome to your Cybersecurity Assistant.");
            Console.ResetColor();

            Console.WriteLine("Ask me about: passwords, phishing, or safe browsing.");
            Console.WriteLine("Type 'exit' to quit.\n");

            // Start conversation
            RunConversation();
        }

        private void RunConversation()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                // Check for exit command
                if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"\nStay safe online, {userName}! Goodbye! 👋");
                    Console.ResetColor();
                    break;
                }

                // Check for empty input
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: I didn't catch that. Please say something!");
                    Console.ResetColor();
                    continue;
                }

                // Get response
                string response = GetResponse(userInput);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Bot: ");
                Console.ResetColor();

                // Typing effect
                foreach (char c in response)
                {
                    Console.Write(c);
                    Thread.Sleep(30);
                }
                Console.WriteLine();
            }
        }

        private string GetResponse(string input)
        {
            string lowerInput = input.ToLower();

            if (lowerInput.Contains("how are you"))
            {
                return $"I'm doing great, {userName}! Ready to teach you about cybersecurity! 🔐";
            }
            else if (lowerInput.Contains("purpose") || lowerInput.Contains("what do you do"))
            {
                return $"My purpose is to help you stay safe online, {userName}! Ask me anything about cybersecurity.";
            }
            else if (lowerInput.Contains("password"))
            {
                return "🔑 TIP: Use strong passwords with 12+ characters, mix of letters, numbers, and symbols. Never reuse passwords across different sites!";
            }
            else if (lowerInput.Contains("phishing"))
            {
                return "🎣 WARNING: Phishing emails try to steal your info! Always check the sender's email address and never click suspicious links.";
            }
            else if (lowerInput.Contains("safe browsing") || lowerInput.Contains("browsing"))
            {
                return "🌐 SAFE BROWSING: Look for 'https://' and the padlock icon in the address bar. Avoid using public Wi-Fi for banking or shopping.";
            }
            else
            {
                return "I didn't quite understand that. Could you rephrase? Try asking about: passwords, phishing, or safe browsing.";
            }
        }
    }
}