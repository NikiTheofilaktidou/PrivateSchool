using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Errors
{
    public class ViewError
    {        
        public static void PrintMenuError()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press E for exit or try choosing an option again");
            Console.ResetColor();
        }
        public static void PrintDateError()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You did not provide the date in the correct form\nPlease try Again");
            Console.WriteLine();
            Console.WriteLine("Correct Date Form: YYYY,MM,DD ex 2021,12,6");
            Console.ResetColor();
        }
        public static void PrintNotOnlyLettersError()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You did not provide correct form for your input\nPlease try Again");
            Console.WriteLine();
            Console.WriteLine("Correct Input Form: Please use only letters.");
            Console.ResetColor();
        }
        public static void PrintNotOnlyDigitsError()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You did not provide correct form for your input\nPlease try Again");
            Console.WriteLine();
            Console.WriteLine("Correct Input Form: Please use only numbers.");
            Console.ResetColor();
        }

    }
}
