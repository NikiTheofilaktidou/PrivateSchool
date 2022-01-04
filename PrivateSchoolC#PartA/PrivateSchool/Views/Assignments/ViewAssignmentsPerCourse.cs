using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Assignments
{
    public class ViewAssignmentsPerCourse
    {
        public static void PrintAssignmentsPerCourse(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Course",-10}{"",-10}{"",-20}{"Assignments",-45}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.PrintDetails();
                if(course.Assignments.Count != 0)
                {
                    foreach (var assignment in course.Assignments)
                    {
                        Console.Write($"{ "",20}{" * ",20}");
                        assignment.PrintTitle();
                    }
                }
                else
                {
                    Console.Write($"{ "",20}{" ! ",20}");
                    Console.WriteLine("No Assignments");
                }
                
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{new string('.', 80)}");
                Console.ResetColor();
            }
        }
    }
}
