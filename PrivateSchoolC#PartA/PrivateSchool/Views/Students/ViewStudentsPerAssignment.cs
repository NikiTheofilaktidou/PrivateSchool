using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Students
{
    public class ViewStudentsPerAssignment
    {
        public static void PrintStudentsPerAssignment(List<Assignment> assignments, string message)
        {
            if (assignments.Count == 0)
            {
                Validations.ViewListIsEmpty.PrintWeeklyAssignmentListIsEmpty();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Assignments With Submission Date On The Same Week With User's Input Date (Working Weekdays)");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{"Assignment",-20}{"Submission Dates Of This Week",-45}{"Students"}");
                Console.ResetColor();
                foreach (var assignment in assignments)
                {
                    if (assignment.Students.Count != 0)
                    {
                        assignment.PrintTitleDate();
                        foreach (var student in assignment.Students)
                        {
                            Console.Write($"{ "",45}{" * ",20}");
                            student.PrintFullname();
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"{new string('.', 100)}");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
