using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Students
{
    public class ViewStudentsPerCourse
    {
        public static void PrintStudentsPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Course",-10}{"",-10}{"",-20}{"Students",-45}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.PrintDetails();
                if (course.Students.Count != 0)
                {
                    foreach (var student in course.Students)
                    {
                        Console.Write($"{ "",20}{" * ",20}");
                        student.PrintFullname();
                    }
                }
                else
                {
                    Console.Write($"{"",20}{" ! ",20}");
                    Console.WriteLine("No Students");
                }
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{new string('.', 80)}");
                Console.ResetColor();
            }
        }
    }
}
