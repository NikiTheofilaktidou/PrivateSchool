using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Assignments
{
    public class ViewAssignmentsPerStudent
    {
        public static void PrintAssignmentsPerStudent(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Student",-35}{"Assignments",-40}");
            Console.ResetColor();
            foreach (var student in students)
            {
                student.PrintFullname();
                foreach (var assignment in student.Assignments)
                {
                    Console.Write($"{"",30}");
                    assignment.PrintTitle();
                }
            }
        }

        public static void PrintAssignmentsPerStudentPerCourse(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Student",-35}{"Course",-25}{"Assignments",-40}");
            Console.ResetColor();
            foreach (var student in students)
            {
                student.PrintFullname();
                foreach (var course in student.Courses)
                {
                    Console.Write($"{"",30}");
                    course.PrintTitle();
                    foreach (var assignment in course.Assignments)
                    {
                        Console.Write($"{ "",40}{" * ",20}");
                        assignment.PrintTitle();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"{new string('.', 95)}");
                        Console.ResetColor();
                    }
                }
            }
        }
    }
}
