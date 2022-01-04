using PrivateSchool.Entities;
using System;
using System.Collections.Generic;

namespace PrivateSchool.Views.Assignments
{
    public class ViewAssignment
    {
        public static void PrintAssignments(List<Assignment> assignments, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"",-4}{"Title",-40}{"Description",-60}{"Date of Submission",-35}{"Oral Mark",-15}{"Total Mark",-10}");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                assignment.Print();
            }
        }       
    }
}
