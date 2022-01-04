using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.UserInteraction
{
    public class ViewFinal
    {
      public static void PrintGoodbye()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"|*"}");
            Console.Write($"{"~",80}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{" ~ "}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{"~"}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{" GOODBYE "}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{"~"}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{" ~ "}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{"~"}");
            Console.WriteLine($"{ "*|",70}");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
