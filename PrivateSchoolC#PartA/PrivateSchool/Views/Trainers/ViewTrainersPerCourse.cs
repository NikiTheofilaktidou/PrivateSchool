using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Trainers
{
    public class ViewTrainersPerCourse
    {
        public static void PrintTrainersPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Course",-10}{"",-10}{"",-20}{"Trainers",-45}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.PrintDetails();
                if (course.Trainers.Count != 0)
                {
                    foreach (var trainer in course.Trainers)
                    {
                        Console.Write($"{ "",20}{" * ",20}");
                        trainer.PrintFullname();
                    }
                }
                else
                {
                    Console.Write($"{ "",20}{" ! ",20}");
                    Console.WriteLine("No Trainers");
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{new string('.', 80)}");
                Console.ResetColor();
            }
        }
    }
}
