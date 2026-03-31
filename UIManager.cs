using System;

namespace CybersecurityChatbot
{
    public static class UIManager
    {
        public static void ShowAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string art = @"
╔══════════════════════════════════════════════════════╗
║                                                      ║
║     ██████╗██╗   ██╗██████╗ ███████╗██████╗          ║
║    ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗         ║
║    ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝         ║
║    ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗         ║
║    ╚██████╗   ██║   ██████╔╝███████╗██║  ██║         ║
║     ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝         ║
║                                                      ║
║         🔒  CYBERSECURITY AWARENESS BOT  🔒          ║
║              Your Safety Online Matters              ║
║                                                      ║
╚══════════════════════════════════════════════════════╝
";
            Console.WriteLine(art);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}