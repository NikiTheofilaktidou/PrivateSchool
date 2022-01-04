using PrivateSchool.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views
{
    public class ViewAskInput
    {
        public static DateTime AskDate()
        {
            Console.WriteLine("Give Date in the form: YYYY,MM,DD ex 2021,12,6");
            string input = Console.ReadLine();

            DateTime subDate;
            bool a = DateTime.TryParse(input, out subDate);
            Console.Clear();

            return subDate;
        }
        public static int AskId()
        {
            string input;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("Pick A Number (Choose a listing by it's Corresponding Number, ex 2)");
            Console.WriteLine("");
            Console.ResetColor();
            input = Console.ReadLine();
            int id;
            int.TryParse(input, out id);
            Console.Clear();
            return id;
        }
    }
}
