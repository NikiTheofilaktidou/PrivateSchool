using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Students
{
    public class ViewStudentsWithManyCourses
    {
        public static void PrintStudentsWithManyCourses(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Student",-40}{"Courses",-45}");
            Console.ResetColor();
            foreach (var student in students)
            {
                if (student.Courses.Count > 1)
                {
                    student.PrintFullname();
                    foreach (var course in student.Courses)
                    {
                        Console.Write($"{"",20}{" * ",20}");
                        course.PrintTitle();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{new string('.', 80)}");
                    Console.ResetColor();
                }
            }
        }
    }
}
