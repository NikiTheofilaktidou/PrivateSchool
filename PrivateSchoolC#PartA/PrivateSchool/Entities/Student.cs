using System;
using System.Collections.Generic;

namespace PrivateSchool.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double TuitionFees { get; set; }

        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Course> Courses { get; set; } = new List<Course>();
        public void Print()
        {
            Console.WriteLine($"{StudentId,-4}{FirstName,-20}{LastName,-25}{DateOfBirth,-35}{TuitionFees,-10}");
        }
        public void PrintFullname()
        {
            Console.WriteLine($"{FirstName,-10}{LastName,-15}");
        }
    }
}
