using PrivateSchool.Controllers;
using PrivateSchool.Views.Menu;
using PrivateSchool.Views.UserInteraction;
using System;

namespace PrivateSchool
{
    public class Application
    {
        public static void Run()
        {
            Controller controller = new Controller();
            string input;
            do
            {                
                input = ViewMenu.PrintMenu();
                switch (input)
                {
                    case "1": controller.ReadAllStudents(); break;
                    case "2": controller.ReadAllTrainers(); break;
                    case "3": controller.ReadAllCourses(); break;
                    case "4": controller.ReadAllAssignments(); break;
                    case "5": controller.ReadAllStudentsPerCourse(); break;
                    case "6": controller.ReadAllTrainersPerCourse(); break;
                    case "7": controller.ReadAllAssignmentsPerCourse(); break;
                    case "8": controller.ReadAllAssignmentsPerStudent(); break;
                    case "9": controller.ReadAllAssignmentsPerStudentPerCourse(); break;
                    case "10": controller.ReadAllStudentsWithManyCourses(); break;
                    case "11": controller.CreateStudent(); Console.WriteLine("Press 10 to add more or E to exit"); ; break;
                    case "12": controller.CreateTrainer(); break;
                    case "13": controller.CreateCourse(); break;
                    case "14": controller.CreateAssignment(); break;
                    case "15": controller.PairStudentWithCourse(); break;
                    case "16": controller.PairTrainerWithCourse(); break;
                    case "17": controller.PairAssignmentWithCourse(); break;
                    case "18": controller.PairAssignmentWithStudent(); break;
                    case "19": controller.ReadAllStudentsPerAssignmentPerDate(); break;
                    case "E":  ViewFinal.PrintGoodbye(); break;
                    default: controller.ReadMenuError(); break;
                } 
            } while (input != "E");
        }
    }
}
