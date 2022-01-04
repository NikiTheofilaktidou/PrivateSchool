using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Entities
{
    public class Trainer
    {
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();

        public void Print()
        {
            Console.WriteLine($"{TrainerId,-4}{FirstName,-20}{LastName,-25}{Subject,-50}");

        }
        public void PrintFullname()
        {
            Console.WriteLine($"{FirstName,-10}{LastName}");
        }
    }
}
