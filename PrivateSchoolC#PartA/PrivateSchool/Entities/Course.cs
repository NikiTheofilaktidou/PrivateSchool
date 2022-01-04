using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Entities
{
    public class Course
    {        
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public Enums.Type Type { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }

        //Navigation Properties
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public void Print()
        {
            Console.WriteLine($"{CourseId,-4}{Title,-10}{Stream,-10}{Type,-15}{Start_Date,-28}{End_Date,-35}");
        }
        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-10}{Type,-15}");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{Title,-10}{Stream,-10}{Type,-15}");
        }
    }
}
