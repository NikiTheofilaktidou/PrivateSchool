using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views.UserInteraction
{
    public class ViewCreateListing
    {
        public static Course CreateCourse()
        {
            string title;
            Console.WriteLine("Give Course's Title (The name must contain ONLY letters)");
            title = Console.ReadLine();
            //do
            //{
            //    title = Console.ReadLine();
            //    if (!Validations.InputValidation.HasOnlyLetters(title))  -- den mou doulevei..
            //    {
            //        Errors.ViewError.PrintNotOnlyLettersError();
            //    }
            //} 
            //while (!Validations.InputValidation.HasOnlyLetters(title));
            
            Console.WriteLine("Give Course's Stream (ex CB13)");
            string stream = Console.ReadLine();

            Console.WriteLine("select Type");
            string[] types = Enum.GetNames(typeof(Enums.Type));

            for (int i = 0; i < types.Length; i++)
            {
                Console.WriteLine($"{i + 1,-4}-{types[i],-4}");
            }
            int choice = Convert.ToInt32(Console.ReadLine());
            Enums.Type t = (Enums.Type)choice;

            Console.WriteLine("Give Course's Start Date (YYYY-MM-DD, ex: 1990-12-31)");
            string inputStartDate = Console.ReadLine();
            DateTime startDate;
            DateTime.TryParse(inputStartDate, out startDate);

            DateTime endDate = new DateTime();
            if (t == Enums.Type.Part_Time)
            {
                endDate = startDate.AddMonths(6);
            }
            else if (t == Enums.Type.Full_Time)
            {
                endDate = startDate.AddMonths(3);
            }
            Course obj = new Course()
            {
                Title = title,
                Stream = stream,
                Type = t,
                Start_Date = startDate,
                End_Date = endDate
            };
            return obj;
        }
        public static Trainer CreateTrainer()
        {
            Console.WriteLine("Give Trainer's First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Give Trainer's Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Give Trainer's Subject (programming language that the Trainer specializes in)");
            string subject = Console.ReadLine();
            Trainer obj = new Trainer()
            {
                FirstName = firstName,
                LastName = lastName,
                Subject = "Specializes in " + subject
            };
            return obj;
        }
        public static void RelateTrainer()
        {
            Console.WriteLine("");
        }
        public static Student CreateStudent()
        {
            Console.WriteLine("Give Student's First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Give Student's Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Give Student's Date of Birth (YYYY-MM-DD, ex: 1990-12-31)");
            string inputBirthDate = Console.ReadLine();
            DateTime birthDate;
            DateTime.TryParse(inputBirthDate, out birthDate);

            Console.WriteLine("Give the Student's Tuition Fees");
            string inputTuitionFees = Console.ReadLine();
            double tuitionFees;
            double.TryParse(inputTuitionFees, out tuitionFees);
            Student obj = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = birthDate,
                TuitionFees = tuitionFees
            };
            return obj;
        }
        public static Assignment CreateAssignment()
        {
            Console.WriteLine("Give Assignment's Title");
            string title = Console.ReadLine();

            Console.WriteLine("Give Assignment's Description");
            string description = Console.ReadLine();

            Console.WriteLine("Give Assignment's Submission Date (YYYY-MM-DD, ex: 2021-12-31)");
            string inputSubDate = Console.ReadLine();
            DateTime submissionDate;
            DateTime.TryParse(inputSubDate, out submissionDate);

            Console.WriteLine("Give Oral Mark for this Assignment");
            string inputOMark = Console.ReadLine();
            int oralMark;
            int.TryParse(inputOMark, out oralMark);

            Console.WriteLine("Give Oral Mark for this Assignment");
            string inputTMark = Console.ReadLine();
            int totalMark;
            int.TryParse(inputTMark, out totalMark);

            Assignment obj = new Assignment()
            {
                Title = title,
                Description = description,
                SubmissionDate = submissionDate,
                OralMark = oralMark,
                TotalMark = totalMark
            };
            return obj;
        }
    }
}
