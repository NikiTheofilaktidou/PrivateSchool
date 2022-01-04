using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.Courses
{
    public class ViewCourse
    {
        public static void PrintCourses(List<Course> courses, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"",-4}{"Title",-10}{"Stream",-10}{"Type",-15}{"Start Date",-28}{"End Date",-35}");
            Console.ResetColor();
            foreach (var course in courses)
            {
                course.Print();
            }
        }
        public static void PrintPairedCourse(Student student, Course course)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"",2}You paired the student ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{student.FirstName} {student.LastName}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" with the course ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{course.Type} {course.Title}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(".");
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void PrintPairedCourse(Trainer trainer, Course course)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{"",2}You paired the trainer ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{trainer.FirstName} {trainer.LastName}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" with the course ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{course.Type} {course.Title}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(".");
            Console.ResetColor();
            Console.WriteLine();
        }
        public static void PrintPairedCourse(Assignment assignment, Course course)
        {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{"",2}You paired the assignment ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{assignment.Title}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" with the course ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"{course.Type} {course.Title}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(".");
                Console.ResetColor();
                Console.WriteLine();
        }        
    }
}

//Relate Object
//Do you wish to Pick or Add Trainers to the Course?
//1.Pick 2.Create Trainer
//1->Lista me trainers. To input that einai to id
//Pairnw to id kai lew phgaine sto db.Trainers kai psakse ta id kai an vreis to id epestrepse mou to Onoma kai to epwnumo tou trainer
//To emfanizw. Ksanarwtaw an thelei na pros8esei h na pickarei gia to ma8hma trianers-> do while
//kanw relate ka8e id me to course