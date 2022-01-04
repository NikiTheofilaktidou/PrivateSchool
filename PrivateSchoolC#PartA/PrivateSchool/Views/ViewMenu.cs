using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Menu
{
    public class ViewMenu
    {
        public static string PrintMenu()
        {
            const int first = -40;
            const int second = -38;
            const int third = -55;
            string input;

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{"|*"}");
            Console.Write($"{"~",80}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{" ~ "}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{"~"}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{" MENU "}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{"~"}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{" ~ "}");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{"~"}");
            Console.WriteLine($"{ "*|",70}");
            Console.WriteLine();
            Console.ResetColor();

            Console.WriteLine($"{"  ---------- ALL DATA ----------  ",first}{"------- ADD NEW DATA -------",second}{"------ CHECK ASSIGNMENT SUBMISSIONS WEEKLY ------",third}{"------- PRESS E FOR EXIT -------"}");
            Console.WriteLine($"{"1 - Students",first}{"11 - Add Students",second}{"19 - Enter Date",third}");
            Console.WriteLine($"{"2 - Trainers",first}{"12 - Add Trainers",second}");
            Console.WriteLine($"{"3 - Courses",first}{"13 - Add Courses",second}");
            Console.WriteLine($"{"4 - Assignments",first}{"14 - Add Assignments",second}");
            Console.WriteLine($"{"5 - Students Per Course",first}{"15 - Pair Students With Course",second}");
            Console.WriteLine($"{"6 - Trainers Per Course",first}{"16 - Pair Trainers With Course",second}");
            Console.WriteLine($"{"7 - Assignments Per Course",first}{"17 - Pair Assignments With Course",second}");
            Console.WriteLine($"{"8 - Assignments Per Student",first}{"18 - Pair Assignments With Student",second}");
            Console.WriteLine($"{"9 - Assignments Per Student Per Course",first}");
            Console.WriteLine($"{"10 - Students With Many Courses",first}");
            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Choose an option");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\n(Press ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("ESC");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" to correct your choice)");
            Console.WriteLine();
            Console.WriteLine();
            Console.ResetColor();
            input = Console.ReadLine();
            Console.Clear();
            return input;
        }
    }
}
