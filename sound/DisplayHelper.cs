using System;

namespace CyberBotSA
{
    public class DisplayHelper
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
  ██████╗██╗   ██╗██████╗ ███████╗██████╗     ██████╗  ██████╗ ████████╗
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔══██╗██╔═══██╗╚══██╔══╝
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██████╔╝██║   ██║   ██║   
 ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██╔══██╗██║   ██║   ██║   
 ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ██████╔╝╚██████╔╝   ██║   
  ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
         ███████╗ █████╗ ███████╗███████╗████████╗██╗   ██╗
         ██╔════╝██╔══██╗██╔════╝██╔════╝╚══██╔══╝╚██╗ ██╔╝
         ███████╗███████║█████╗  █████╗     ██║    ╚████╔╝ 
         ╚════██║██╔══██║██╔══╝  ██╔══╝     ██║     ╚██╔╝  
         ███████║██║  ██║██║     ███████╗   ██║      ██║   
         ╚══════╝╚═╝  ╚═╝╚═╝     ╚══════╝   ╚═╝      ╚═╝  
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("  ============================================================");
            Console.WriteLine("       Your trusted guide to staying safe online in SA");
            Console.WriteLine("  ============================================================");
            Console.ResetColor();
        }
    }
}

