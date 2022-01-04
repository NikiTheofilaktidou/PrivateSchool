using PrivateSchool.RepositoryService;
using PrivateSchool.Views;
using PrivateSchool.Views.Assignments;
using PrivateSchool.Views.Courses;
using PrivateSchool.Views.Errors;
using PrivateSchool.Views.Students;
using PrivateSchool.Views.Trainers;
using PrivateSchool.Views.UserInteraction;

namespace PrivateSchool.Controllers
{
    public class Controller
    {
        StudentService studentService = new StudentService();
        TrainerService trainerService = new TrainerService();
        CourseService courseService = new CourseService();
        AssignmentService assignmentService = new AssignmentService();

        #region --Read Data--
        public void ReadAllStudents()
        {
            var allStudents = studentService.GetStudents();
            ViewStudent.PrintStudents(allStudents, "All Students");
        }
        public void ReadAllTrainers()
        {
            var allTrainers = trainerService.GetTrainers();
            ViewTrainer.PrintTrainers(allTrainers, "All Trainers");
        }
        public void ReadAllCourses()
        {
            var allCourses = courseService.GetCourses();
            ViewCourse.PrintCourses(allCourses, "All Courses");
        }
        public void ReadAllAssignments()
        {
            var allAssignments = assignmentService.GetAssignments();
            ViewAssignment.PrintAssignments(allAssignments, "All Assignments");
        }
        public void ReadAllStudentsPerCourse()
        {
            var allCourses = courseService.GetCourses();
            ViewStudentsPerCourse.PrintStudentsPerCourse(allCourses, "All Students Per Course");
        }
        public void ReadAllStudentsPerAssignmentPerDate()
        {
            var date = ViewAskInput.AskDate();
            var dates = Date.GetDatesList(date);
            var allAssignmentsOfWeek = assignmentService.GetAssignmentsOfWeek(dates);
            ViewStudentsPerAssignment.PrintStudentsPerAssignment(allAssignmentsOfWeek, "All Assignments To Be Submitted By Students On The Week That Includes Your Input");
        }
        public void ReadAllTrainersPerCourse()
        {
            var allCourses = courseService.GetCourses();
            ViewTrainersPerCourse.PrintTrainersPerCourse(allCourses, "All Trainers Per Course");
        }
        public void ReadAllAssignmentsPerCourse()
        {
            var allCourses = courseService.GetCourses();
            ViewAssignmentsPerCourse.PrintAssignmentsPerCourse(allCourses, "All Assignments Per Course");
        }
        public void ReadAllAssignmentsPerStudent()
        {
            var allStudents = studentService.GetStudents();
            ViewAssignmentsPerStudent.PrintAssignmentsPerStudent(allStudents, "All Assignments Per Student");
        }
        public void ReadAllAssignmentsPerStudentPerCourse()
        {
            var allStudents = studentService.GetStudents();
            ViewAssignmentsPerStudent.PrintAssignmentsPerStudentPerCourse(allStudents, "All Assignments Per Course Per Student");
        }

        public void ReadAllStudentsWithManyCourses()
        {
            var allStudents = studentService.GetStudents();
            ViewStudentsWithManyCourses.PrintStudentsWithManyCourses(allStudents, "Students With Many Courses");
        }
        public void ReadMenuError()
        {
            ViewError.PrintMenuError();
        }
        #endregion

        #region --Create Data--
        public void CreateStudent()
        {
            var student = ViewCreateListing.CreateStudent();
            studentService.CreateStudent(student);
        }
        public void CreateTrainer()
        {
            var trainer = ViewCreateListing.CreateTrainer();
            trainerService.CreateTrainer(trainer);
        } 
        public void CreateCourse()
        {
            var course = ViewCreateListing.CreateCourse();
            courseService.CreateCourse(course);
        }
        public void CreateAssignment()
        {
            var assignment = ViewCreateListing.CreateAssignment();
            assignmentService.CreateAssignment(assignment);
        }
        #endregion

        #region --Relate Data--
        public void PairStudentWithCourse()
        {
            ReadAllStudents();
            int a = ViewAskInput.AskId();
            ReadAllCourses();
            int b = ViewAskInput.AskId();
            var student = studentService.GetStudent(a);
            var course = courseService.GetCourse(b);
            studentService.RelateStudentWithCourse(student, course);
            ViewCourse.PrintPairedCourse(student, course);
        }
        public void PairTrainerWithCourse()
        {
            ReadAllTrainers();
            int a = ViewAskInput.AskId();
            ReadAllCourses();
            int b = ViewAskInput.AskId();
            var trainer = trainerService.GetTrainer(a);
            var course = courseService.GetCourse(b);
            trainerService.RelateTrainerWithCourse(trainer, course);
            ViewCourse.PrintPairedCourse(trainer, course);
        }
        public void PairAssignmentWithCourse()
        {
            ReadAllAssignments();
            int a = ViewAskInput.AskId();
            ReadAllCourses();
            int b = ViewAskInput.AskId();
            var assignment = assignmentService.GetAssignment(a);
            var course = courseService.GetCourse(b);
            assignmentService.RelateAssignmentWithCourse(assignment, course);
            ViewCourse.PrintPairedCourse(assignment, course);
        }
        public void PairAssignmentWithStudent()
        {
            ReadAllAssignments();
            int a = ViewAskInput.AskId();
            ReadAllStudents();
            int b = ViewAskInput.AskId();
            var assignment = assignmentService.GetAssignment(a);
            var student = studentService.GetStudent(b);
            assignmentService.RelateAssignmentWithStudent(assignment, student);
            ViewStudent.PrintPairedStudent(assignment, student);
        }
        #endregion
    }
}