using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Validations
{
    public class ViewListIsEmpty
    {
        public static void PrintCourseListIsEmpty()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("There are no courses to display");
            Console.ResetColor();
        }
        public static void PrintTrainerListIsEmpty()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("There are no trainers to display");
            Console.ResetColor();
        }
        public static void PrintStudentListIsEmpty()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("There are no assignments to display during the week which includes the input");
            Console.ResetColor();
        }
        public static void PrintAssignmentListIsEmpty()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("There are no assignments to display");
            Console.ResetColor();
        }
        public static void PrintWeeklyAssignmentListIsEmpty()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("There are no assignments to display during the week which includes the input OR wrong input ");
            Console.ResetColor();
        }
    }
}
