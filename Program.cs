using System;

namespace CybersecurityChatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.WindowWidth = 90;
            Console.WindowHeight = 40;
            
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}