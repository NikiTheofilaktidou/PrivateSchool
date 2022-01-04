using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Students
{
    public class ViewStudent
    {
        public static void PrintStudents(List<Student> students, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"",-4}{"First Name",-20}{"Last Name",-25}{"Date Of Birth",-35}{"Tuition Fees",-10}");
            Console.ResetColor();
            foreach (var student in students)
            {
                student.Print();
            }
        }
        public static void PrintPairedStudent(Assignment assignment, Student student)
        {
            Console.WriteLine();            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"",2}You paired the assignment ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{assignment.Title}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" with the student ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{student.FirstName} {student.LastName}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(".");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
