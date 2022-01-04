using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Database
{
    public class MyDatabase
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();        
        public MyDatabase()
        {
            #region Seeding Students
            //-----------------Seeding Students--------------
            Student s1 = new Student()
            {     
                StudentId=1,
                FirstName = "Niki",
                LastName = "Theofilaktidou",
                DateOfBirth = new DateTime(1988, 6, 10),
                TuitionFees =5000
            };
            Student s2 = new Student()
            {         
                StudentId=2,
                FirstName = "Stelios",
                LastName = "Mousafiris",
                DateOfBirth = new DateTime(1989, 10, 21),
                TuitionFees = 5000
            };
            Student s3 = new Student()
            {
                StudentId=3,
                FirstName = "Kostas",
                LastName = "Papadopoulos",
                DateOfBirth = new DateTime(1967, 6, 23),
                TuitionFees = 10000
            };
            Student s4 = new Student()
            {
                StudentId = 4,
                FirstName = "Petros",
                LastName = "Lilipouteios",
                DateOfBirth = new DateTime(1994, 3, 27),
                TuitionFees = 6000
            };
            Student s5 = new Student()
            {
                StudentId = 5,
                FirstName = "Paulos",
                LastName = "Oikonomou",
                DateOfBirth = new DateTime(1980, 6, 23),
                TuitionFees = 8000
            };
            Student s6 = new Student()
            {
                StudentId = 6,
                FirstName = "Tasos",
                LastName = "Aghsilaou",
                DateOfBirth = new DateTime(1993, 7, 8),
                TuitionFees = 5000
            };
            Student s7 = new Student()
            {
                StudentId = 7,
                FirstName = "Maria",
                LastName = "Pappadopoulou",
                DateOfBirth = new DateTime(1971, 1, 23),
                TuitionFees = 10000
            };
            Student s8 = new Student()
            {
                StudentId = 8,
                FirstName = "Fillipos",
                LastName = "Chatzixristou",
                DateOfBirth = new DateTime(1988, 7, 14),
                TuitionFees = 5000
            };
            Student s9 = new Student()
            {
                StudentId = 9,
                FirstName = "Aristea",
                LastName = "Arghrh",
                DateOfBirth = new DateTime(1992, 10, 12),
                TuitionFees = 7000
            };
            Student s10 = new Student()
            {
                StudentId = 10,
                FirstName = "Galhnos",
                LastName = "Theodwrou",
                DateOfBirth = new DateTime(1987, 2, 10),
                TuitionFees = 8000
            };
            Student s11 = new Student()
            {
                StudentId = 11,
                FirstName = "Xarilaos",
                LastName = "Trikouphs",
                DateOfBirth = new DateTime(1988, 6, 6),
                TuitionFees = 8000
            };
            Student s12 = new Student()
            {
                StudentId = 12,
                FirstName = "Peristera",
                LastName = "Xatzimitzithodwra",
                DateOfBirth = new DateTime(1995, 9, 8),
                TuitionFees = 7000
            };
            Student s13 = new Student()
            {
                StudentId = 13,
                FirstName = "Antwnia",
                LastName = "Kavafh",
                DateOfBirth = new DateTime(1985, 7, 21),
                TuitionFees = 10000
            };
            Student s14 = new Student()
            {
                StudentId = 14,
                FirstName = "Tasos",
                LastName = "Theoxarhs",
                DateOfBirth = new DateTime(1990, 5, 23),
                TuitionFees = 7000
            };
            Student s15 = new Student()
            {
                StudentId = 15,
                FirstName = "Antwnia",
                LastName = "Filippinou",
                DateOfBirth = new DateTime(1990, 3, 12),
                TuitionFees = 5000
            };
            Student s16 = new Student()
            {
                StudentId = 16,
                FirstName = "Maria",
                LastName = "Peristerou",
                DateOfBirth = new DateTime(1988, 4, 21),
                TuitionFees = 7000
            };
            Student s17 = new Student()
            {
                StudentId = 17,
                FirstName = "Fotis",
                LastName = "Ntouramidis",
                DateOfBirth = new DateTime(1990, 3, 2),
                TuitionFees = 10000
            };
            Student s18 = new Student()
            {
                StudentId = 18,
                FirstName = "Malamas",
                LastName = "Karadhmhtriou",
                DateOfBirth = new DateTime(1989, 3, 12),
                TuitionFees = 5000
            };
            Student s19 = new Student()
            {
                StudentId = 19,
                FirstName = "Peiklhs",
                LastName = "Patroklou",
                DateOfBirth = new DateTime(1988, 6, 2),
                TuitionFees = 12000
            };
            Student s20 = new Student()
            {
                StudentId = 20,
                FirstName = "Euan8ia",
                LastName = "Themistokleous",
                DateOfBirth = new DateTime(1978, 2, 23),
                TuitionFees = 6000
            };
            #endregion

            #region Seeding Courses
            //----------------Seeding Courses----------------
            Course c1 = new Course()
            {
                CourseId=1,
                Title="C#",
                Stream="CB15",
                Type=Enums.Type.Full_Time,
                Start_Date= new DateTime(2018,10,20),
                End_Date= new DateTime(2019,1,20)
            };
            c1.Students = new List<Student>() {s1,s2,s3,s4,s5};
            s1.Courses.Add(c1);
            s2.Courses.Add(c1);
            s3.Courses.Add(c1);
            s4.Courses.Add(c1);
            s5.Courses.Add(c1);
           Course c2 = new Course()
           {
               CourseId=2,
               Title = "C#",
               Stream = "CB15",
               Type = Enums.Type.Part_Time,
               Start_Date = new DateTime(2019, 10, 20),
               End_Date = new DateTime(2020, 4, 20)
           };
            c2.Students = new List<Student>() {s6,s7,s8,s9,s10};
            s6.Courses.Add(c2);
            s7.Courses.Add(c2);
            s8.Courses.Add(c2);
            s9.Courses.Add(c2);
            s10.Courses.Add(c2);
            Course c3 = new Course()
            {
                CourseId=3,
                Title = "Java",
                Stream = "CB13",
                Type = Enums.Type.Full_Time,
                Start_Date = new DateTime(2019, 10, 20),
                End_Date = new DateTime(2020, 1, 20)
            };
            c3.Students = new List<Student>() {s11,s12,s13,s14,s15,s3,s5};
            s11.Courses.Add(c3);
            s12.Courses.Add(c3);
            s13.Courses.Add(c3);
            s14.Courses.Add(c3);
            s15.Courses.Add(c3);
            s3.Courses.Add(c3);
            s5.Courses.Add(c3);
            Course c4 = new Course()
            {
                CourseId=4,
                Title = "Python",
                Stream = "CB13",
                Type = Enums.Type.Part_Time,
                Start_Date = new DateTime(2020, 10, 20),
                End_Date = new DateTime(2021, 4, 20)
            };
            c4.Students = new List<Student>() {s16,s17,s18,s19,s20,s5,s10};
            s5.Courses.Add(c4);
            s16.Courses.Add(c4);
            s17.Courses.Add(c4);
            s18.Courses.Add(c4);
            s19.Courses.Add(c4);
            s20.Courses.Add(c4);
            s10.Courses.Add(c4);
            #endregion

            #region Seeding Trainers
            //-----------------Seeding Trainers--------------
            Trainer t1 = new Trainer()
            {
                TrainerId=1,
                FirstName = "Hector",
                LastName = "Gkatsos",
                Subject = "Specializes in C#",
            };
            t1.Courses = new List<Course>() {c1};
            c1.Trainers.Add(t1);
            Trainer t2 = new Trainer()
            {
                TrainerId=2,
                FirstName = "Helectra",
                LastName = "Mariannou",
                Subject = "Specializes in Java",
            };
            t2.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t2);
            Trainer t3 = new Trainer()
            {
                TrainerId=3,
                FirstName = "Maria",
                LastName = "Chatzikosta",
                Subject = "Specializes in Python",
            };
            t3.Courses = new List<Course>() { c2,c3 };
            c2.Trainers.Add(t3);
            c3.Trainers.Add(t3);
            Trainer t4 = new Trainer()
            {
                TrainerId=4,
                FirstName = "Heracles",
                LastName = "Eksarxakos",
                Subject = "Specializes in SQL",
            };
            t4.Courses = new List<Course>() { c1 };
            c1.Trainers.Add(t4);
            Trainer t5 = new Trainer()
            {
                TrainerId = 5,
                FirstName = "Eutuxhs",
                LastName = "Dimitriadhs",
                Subject = "Specializes in C++",
            };
            t5.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t5);
            Trainer t6 = new Trainer()
            {
                TrainerId = 6,
                FirstName = "Nikos",
                LastName = "Hrakleiou",
                Subject = "Specializes in Python",
            };
            t6.Courses = new List<Course>() { c2, c3 };
            c2.Trainers.Add(t6);
            c3.Trainers.Add(t6);
            Trainer t7 = new Trainer()
            {
                TrainerId = 7,
                FirstName = "Pasxalhs",
                LastName = "Theofilopoulos",
                Subject = "Specializes in JavaScript",
            };
            t7.Courses = new List<Course>() { c1 };
            c1.Trainers.Add(t7);
            Trainer t8 = new Trainer()
            {
                TrainerId = 8,
                FirstName = "Maria",
                LastName = "Kuritsh",
                Subject = "Specializes in C#",
            };
            t8.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t8);
            #endregion

            #region Seeding Assignments
            //-----------------Seeding Assignments-----------
            Assignment a1 = new Assignment()
            {
                AssignmentId=1,
                Title = "CodeWars",
                Description="Solve 3 katas on C# of 6kyu",
                SubmissionDate = new DateTime(2018,10,30),
                OralMark=80,
                TotalMark=87
            };
            a1.Course = c1;
            c1.Assignments.Add(a1);
            a1.Students = new List<Student>() { s1,s2,s3,s4,s5 };
            s1.Assignments.Add(a1);
            s2.Assignments.Add(a1);
            s3.Assignments.Add(a1);
            s4.Assignments.Add(a1);
            s5.Assignments.Add(a1);
            Assignment a2 = new Assignment()
            {
                AssignmentId=2,
                Title = "Calculator",
                Description = "Create a calculator",
                SubmissionDate = new DateTime(2018,11,15),
                OralMark = 76,
                TotalMark = 55
            };
            a2.Course = c1;
            c1.Assignments.Add(a2);
            a2.Students = new List<Student>() {s1,s2,s3,s4,s5};
            s1.Assignments.Add(a2);
            s2.Assignments.Add(a2);
            s3.Assignments.Add(a2);
            s4.Assignments.Add(a2);
            s5.Assignments.Add(a2);
            Assignment a3 = new Assignment()
            {
                AssignmentId=3,
                Title = "ATM",
                Description = "Create a simple ATM software",
                SubmissionDate = new DateTime(2018, 12, 3),
                OralMark = 80,
                TotalMark = 98
            };
            a3.Course = c1;
            c1.Assignments.Add(a3);
            a3.Students = new List<Student>() { s1,s2,s3,s4,s5 };
            s1.Assignments.Add(a3);
            s2.Assignments.Add(a3);
            s3.Assignments.Add(a3);
            s4.Assignments.Add(a3);
            s5.Assignments.Add(a3);
            Assignment a4 = new Assignment()
            {
                AssignmentId=4,
                Title = "Barcode generator",
                Description = "Create a barcode generator",
                SubmissionDate = new DateTime(2018, 12, 14),
                OralMark = 89,
                TotalMark = 70
            };
            a4.Course = c1;
            c1.Assignments.Add(a4);
            a4.Students = new List<Student>() { s1,s2,s3,s4,s5 };
            s1.Assignments.Add(a4);
            s2.Assignments.Add(a4);
            s3.Assignments.Add(a4);
            s4.Assignments.Add(a4);
            s5.Assignments.Add(a4);
            Assignment a5 = new Assignment()
            {
                AssignmentId = 5,
                Title = "Notifier",
                Description = "Create a desktop notifier app",
                SubmissionDate = new DateTime(2018, 12, 28),
                OralMark = 90,
                TotalMark = 70
            };
            a5.Course = c1;
            c1.Assignments.Add(a5);
            a5.Students = new List<Student>() { s1,s2,s3,s4,s5 };
            s1.Assignments.Add(a5);
            s2.Assignments.Add(a5);
            s3.Assignments.Add(a5);
            s4.Assignments.Add(a5);
            s5.Assignments.Add(a5);
            Assignment a6 = new Assignment()
            {
                AssignmentId = 6,
                Title = "Search engine",
                Description = "Create a search engine",
                SubmissionDate = new DateTime(2019, 1, 10),
                OralMark = 89,
                TotalMark = 59
            };
            a6.Course = c1;
            c1.Assignments.Add(a6);
            a6.Students = new List<Student>() {s1, s2,s3,s4,s5 };
            s1.Assignments.Add(a6);
            s2.Assignments.Add(a6);
            s3.Assignments.Add(a6);
            s4.Assignments.Add(a6);
            s5.Assignments.Add(a6);
            Assignment a7 = new Assignment()
            {
                AssignmentId = 7,
                Title = "Ebooks",
                Description = "Create an Ebook library and reader",
                SubmissionDate = new DateTime(2019, 1, 18),
                OralMark = 87,
                TotalMark = 90
            };
            a7.Course = c1;
            c1.Assignments.Add(a7);
            a7.Students = new List<Student>() { s1,s2,s3,s4,s5 };
            s1.Assignments.Add(a7);
            s2.Assignments.Add(a7);
            s3.Assignments.Add(a7);
            s4.Assignments.Add(a7);
            s5.Assignments.Add(a7);
            Assignment a8 = new Assignment()
            {
                AssignmentId = 8,
                Title = "Notes",
                Description = "Create a note-taking application",
                SubmissionDate = new DateTime(2019, 11, 20),
                OralMark = 85,
                TotalMark = 77
            };
            a8.Course = c2;
            c2.Assignments.Add(a8);
            a8.Students = new List<Student>() { s6,s7,s8,s9,s10 };
            s6.Assignments.Add(a8);
            s7.Assignments.Add(a8);
            s8.Assignments.Add(a8);
            s9.Assignments.Add(a8);
            s10.Assignments.Add(a8);
            Assignment a9 = new Assignment()
            {
                AssignmentId = 9,
                Title = "Film library",
                Description = "Create a film library database",
                SubmissionDate = new DateTime(2019, 12, 11),
                OralMark = 89,
                TotalMark = 98
            };
            a9.Course = c2;
            c2.Assignments.Add(a9);
            a9.Students = new List<Student>() { s6, s7, s8, s9, s10 };
            s6.Assignments.Add(a9);
            s7.Assignments.Add(a9);
            s8.Assignments.Add(a9);
            s9.Assignments.Add(a9);
            s10.Assignments.Add(a9);
            Assignment a10 = new Assignment()
            {
                AssignmentId = 10,
                Title = "Let's Vote",
                Description = "Create an online voting application",
                SubmissionDate = new DateTime(2019, 12, 27),
                OralMark = 78,
                TotalMark = 80
            };
            a10.Course = c2;
            c2.Assignments.Add(a10);
            a10.Students = new List<Student>() { s6, s7, s8, s9, s10 };
            s6.Assignments.Add(a10);
            s7.Assignments.Add(a10);
            s8.Assignments.Add(a10);
            s9.Assignments.Add(a10);
            s10.Assignments.Add(a10);
            Assignment a11 = new Assignment()
            {
                AssignmentId = 11,
                Title = "Twitter bot",
                Description = "Create a bot connecting to the Twitter API",
                SubmissionDate = new DateTime(2020, 1, 10),
                OralMark = 89,
                TotalMark = 70
            };
            a11.Course = c2;
            c2.Assignments.Add(a11);
            a11.Students = new List<Student>() { s6, s7, s8, s9, s10 };
            s6.Assignments.Add(a11);
            s7.Assignments.Add(a11);
            s8.Assignments.Add(a11);
            s9.Assignments.Add(a11);
            s10.Assignments.Add(a11);
            Assignment a12 = new Assignment()
            {
                AssignmentId = 12,
                Title = "Driving game",
                Description = "Create a game using engines (ex Unity or Gadot)",
                SubmissionDate = new DateTime(2020, 2, 14),
                OralMark = 90,
                TotalMark = 95
            };
            a12.Course = c2;
            c2.Assignments.Add(a12);
            a12.Students = new List<Student>() { s6, s7, s8, s9, s10 };
            s6.Assignments.Add(a12);
            s7.Assignments.Add(a12);
            s8.Assignments.Add(a12);
            s9.Assignments.Add(a12);
            s10.Assignments.Add(a12);
            Assignment a13 = new Assignment()
            {
                AssignmentId = 13,
                Title = "Private School",
                Description = "Create a school-management system",
                SubmissionDate = new DateTime(2020, 3, 10),
                OralMark = 85,
                TotalMark = 75
            };
            a13.Course = c2;
            c2.Assignments.Add(a13);
            a13.Students = new List<Student>() { s6, s7, s8, s9, s10 };
            s6.Assignments.Add(a13);
            s7.Assignments.Add(a13);
            s8.Assignments.Add(a13);
            s9.Assignments.Add(a13);
            s10.Assignments.Add(a13);
            Assignment a14 = new Assignment()
            {
                AssignmentId = 14,
                Title = "Snake game",
                Description = "Create the popular game",
                SubmissionDate = new DateTime(2020, 4, 15),
                OralMark = 87,
                TotalMark = 99
            };
            a14.Course = c2;
            c2.Assignments.Add(a14);
            a14.Students = new List<Student>() { s6, s7, s8, s9, s10 };
            s6.Assignments.Add(a14);
            s7.Assignments.Add(a14);
            s8.Assignments.Add(a14);
            s9.Assignments.Add(a14);
            s10.Assignments.Add(a14);
            Assignment a15 = new Assignment()
            {
                AssignmentId = 15,
                Title = "Airlines",
                Description = "Create an Airline reservation system",
                SubmissionDate = new DateTime(2019, 10, 30),
                OralMark = 90,
                TotalMark = 77
            };
            a15.Course = c3;
            c3.Assignments.Add(a15);
            a15.Students = new List<Student>() { s11, s12, s13, s14, s15,s3,s5 };
            s11.Assignments.Add(a15);
            s12.Assignments.Add(a15);
            s13.Assignments.Add(a15);
            s14.Assignments.Add(a15);
            s15.Assignments.Add(a15);
            s3.Assignments.Add(a15);
            s5.Assignments.Add(a15);
            Assignment a16 = new Assignment()
            {
                AssignmentId = 16,
                Title = "Hospital",
                Description = "Create an e-Healthcare management system",
                SubmissionDate = new DateTime(2019, 11, 15),
                OralMark = 95,
                TotalMark = 77
            };
            a16.Course = c3;
            c3.Assignments.Add(a16);
            a16.Students = new List<Student>() { s11, s12, s13, s14, s15 ,s3,s5};
            s11.Assignments.Add(a16);
            s12.Assignments.Add(a16);
            s13.Assignments.Add(a16);
            s14.Assignments.Add(a16);
            s15.Assignments.Add(a16);
            s3.Assignments.Add(a16);
            s5.Assignments.Add(a15);
            Assignment a17 = new Assignment()
            {
                AssignmentId = 17,
                Title = "Electricity Cost",
                Description = "Create an electricity billing system",
                SubmissionDate = new DateTime(2019, 12, 3),
                OralMark = 67,
                TotalMark = 88
            };
            a17.Course = c3;
            c3.Assignments.Add(a17);
            a17.Students = new List<Student>() { s11, s12, s13, s14, s15,s3,s5 };
            s11.Assignments.Add(a17);
            s12.Assignments.Add(a17);
            s13.Assignments.Add(a17);
            s14.Assignments.Add(a17);
            s15.Assignments.Add(a17);
            s3.Assignments.Add(a17);
            s5.Assignments.Add(a15);
            Assignment a18 = new Assignment()
            {
                AssignmentId = 18,
                Title = "Email Client",
                Description = "Create an Email client software using Java Mail API",
                SubmissionDate = new DateTime(2019, 12, 16),
                OralMark = 90,
                TotalMark = 73
            };
            a18.Course = c3;
            c3.Assignments.Add(a18);
            a18.Students = new List<Student>() { s11, s12, s13, s14, s15,s3,s5 };
            s11.Assignments.Add(a18);
            s12.Assignments.Add(a18);
            s13.Assignments.Add(a18);
            s14.Assignments.Add(a18);
            s15.Assignments.Add(a18);
            s3.Assignments.Add(a18);
            s5.Assignments.Add(a15);
            Assignment a19 = new Assignment()
            {
                AssignmentId = 19,
                Title = "Online Survey",
                Description = "Create an app that launchs online surveys",
                SubmissionDate = new DateTime(2019, 12, 27),
                OralMark = 75,
                TotalMark = 98
            };
            a19.Course = c3;
            c3.Assignments.Add(a19);
            a19.Students = new List<Student>() { s11, s12, s13, s14, s15,s3,s5 };
            s11.Assignments.Add(a19);
            s12.Assignments.Add(a19);
            s13.Assignments.Add(a19);
            s14.Assignments.Add(a19);
            s15.Assignments.Add(a19);
            s3.Assignments.Add(a19);
            s5.Assignments.Add(a15);
            Assignment a20 = new Assignment()
            {
                AssignmentId = 20,
                Title = "Smart City",
                Description = "Create an intergrated platform using a variety of modules",
                SubmissionDate = new DateTime(2020, 1, 10),
                OralMark = 59,
                TotalMark = 71
            };
            a20.Course = c3;
            c3.Assignments.Add(a20);
            a20.Students = new List<Student>() { s11, s12, s13, s14, s15,s3,s5 };
            s11.Assignments.Add(a20);
            s12.Assignments.Add(a20);
            s13.Assignments.Add(a20);
            s14.Assignments.Add(a20);
            s15.Assignments.Add(a20);
            s3.Assignments.Add(a20);
            s5.Assignments.Add(a15);
            Assignment a21 = new Assignment()
            {
                AssignmentId = 21,
                Title = "Supply chain management system",
                Description = "Create an app that manages businesses connected via network",
                SubmissionDate = new DateTime(2020, 1, 17),
                OralMark = 95,
                TotalMark = 85
            };
            a21.Course = c3;
            c3.Assignments.Add(a21);
            a21.Students = new List<Student>() { s11, s12, s13, s14, s15,s3,s5 };
            s11.Assignments.Add(a21);
            s12.Assignments.Add(a21);
            s13.Assignments.Add(a21);
            s14.Assignments.Add(a21);
            s15.Assignments.Add(a21);
            s3.Assignments.Add(a21);
            s5.Assignments.Add(a15);
            Assignment a22 = new Assignment()
            {
                AssignmentId = 22,
                Title = "Tic-Tac-Toe",
                Description = "Create the popular game",
                SubmissionDate = new DateTime(2021, 11, 19),
                OralMark = 93,
                TotalMark = 68
            };
            a22.Course = c4;
            c4.Assignments.Add(a22);
            a22.Students = new List<Student>() { s16, s17, s18, s19, s20, s5,s10 };
            s16.Assignments.Add(a22);
            s17.Assignments.Add(a22);
            s18.Assignments.Add(a22);
            s19.Assignments.Add(a22);
            s20.Assignments.Add(a22);
            s5.Assignments.Add(a22);
            Assignment a23 = new Assignment()
            {
                AssignmentId = 23,
                Title = "Final Countdown",
                Description = "Create a countdown clock and timer",
                SubmissionDate = new DateTime(2021, 12, 10),
                OralMark = 65,
                TotalMark = 77
            };
            a23.Course = c4;
            c4.Assignments.Add(a23);
            a23.Students = new List<Student>() { s16, s17, s18, s19, s20,s5,s10 };
            s16.Assignments.Add(a23);
            s17.Assignments.Add(a23);
            s18.Assignments.Add(a23);
            s19.Assignments.Add(a23);
            s20.Assignments.Add(a23);
            s5.Assignments.Add(a23);
            s10.Assignments.Add(a23);
            Assignment a24 = new Assignment()
            {
                AssignmentId = 24,
                Title = "Music Player",
                Description = "create a music player app",
                SubmissionDate = new DateTime(2021, 12, 28),
                OralMark = 89,
                TotalMark = 70
            };
            a24.Course = c4;
            c4.Assignments.Add(a24);
            a24.Students = new List<Student>() { s16, s17, s18, s19, s20,s5,s10 };
            s16.Assignments.Add(a24);
            s17.Assignments.Add(a24);
            s18.Assignments.Add(a24);
            s19.Assignments.Add(a24);
            s20.Assignments.Add(a24);
            s5.Assignments.Add(a24);
            s10.Assignments.Add(a24);
            Assignment a25 = new Assignment()
            {
                AssignmentId = 25,
                Title = "Website Blocker",
                Description = "Create an app that blocks sites from opening",
                SubmissionDate = new DateTime(2022, 1, 10),
                OralMark = 94,
                TotalMark = 95
            };
            a25.Course = c4;
            c4.Assignments.Add(a25);
            a25.Students = new List<Student>() { s16, s17, s18, s19, s20,s5,s10 };
            s16.Assignments.Add(a25);
            s17.Assignments.Add(a25);
            s18.Assignments.Add(a25);
            s19.Assignments.Add(a25);
            s20.Assignments.Add(a25);
            s5.Assignments.Add(a25);
            s10.Assignments.Add(a25);
            Assignment a26 = new Assignment()
            {
                AssignmentId = 26,
                Title = "Scraping data from Twitter",
                Description = "Create an app that scrapes data from Twitter",
                SubmissionDate = new DateTime(2022, 2, 15),
                OralMark = 65,
                TotalMark = 60
            };
            a26.Course = c4;
            c4.Assignments.Add(a26);
            a26.Students = new List<Student>() { s16, s17, s18, s19, s20,s5,s10 };
            s16.Assignments.Add(a26);
            s17.Assignments.Add(a26);
            s18.Assignments.Add(a26);
            s19.Assignments.Add(a26);
            s20.Assignments.Add(a26);
            s5.Assignments.Add(a26);
            s10.Assignments.Add(a26);
            Assignment a27 = new Assignment()
            {
                AssignmentId = 27,
                Title = "Price Comparison",
                Description = "Create an app providing best offer of products",
                SubmissionDate = new DateTime(2022, 3, 10),
                OralMark = 57,
                TotalMark = 70
            };
            a27.Course = c4;
            c4.Assignments.Add(a27);
            a27.Students = new List<Student>() { s16, s17, s18, s19, s20 ,s5 ,s10};
            s16.Assignments.Add(a27);
            s17.Assignments.Add(a27);
            s18.Assignments.Add(a27);
            s19.Assignments.Add(a27);
            s20.Assignments.Add(a27);
            s5.Assignments.Add(a27);
            s10.Assignments.Add(a27);
            Assignment a28 = new Assignment()
            {
                AssignmentId = 28,
                Title = "Expense Tracker",
                Description = "Create an app that keeps track of the user’s expenses",
                SubmissionDate = new DateTime(2022, 4, 14),
                OralMark = 89,
                TotalMark = 70
            };
            a28.Course = c4;
            c4.Assignments.Add(a28);
            a28.Students = new List<Student>() { s16, s17, s18, s19, s20 ,s5,s10};
            s16.Assignments.Add(a28);
            s17.Assignments.Add(a28);
            s18.Assignments.Add(a28);
            s19.Assignments.Add(a28);
            s20.Assignments.Add(a28);
            s5.Assignments.Add(a28);
            s10.Assignments.Add(a28);
            #endregion

            #region Populate Lists
            List<Student> students = new List<Student>() {s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,s17,s18,s19,s20};
            List<Course> courses = new List<Course>() {c1, c2, c3, c4};
            List<Trainer> trainers = new List<Trainer>() {t1,t2,t3,t4,t5,t6,t7,t8};
            List<Assignment> assignments = new List<Assignment>() {a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13,a14,a15,a16,a17,a18,a19,a20,a21,a22,a23,a24,a25,a26,a27,a28};

            Students.AddRange(students);
            Courses.AddRange(courses);
            Trainers.AddRange(trainers);
            Assignments.AddRange(assignments);
            #endregion
        }
    }
}
