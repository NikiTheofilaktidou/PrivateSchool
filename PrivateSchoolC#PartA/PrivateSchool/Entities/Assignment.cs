using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Entities
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubmissionDate { get; set; }
        public float OralMark { get; set; }
        public float TotalMark { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public Course Course { get; set; } = new Course();
        public void Print()
        {
            Console.WriteLine($"{AssignmentId,-4}{Title,-40}{Description,-60}{SubmissionDate,-35}{OralMark,-15}{TotalMark,-10}");
        }
        public void PrintTitle()
        {
            Console.WriteLine($"{Title,-40}");
        }
        public void PrintTitleDate()
        {
            Console.WriteLine($"{Title,-20}{SubmissionDate.DayOfWeek,-10}{SubmissionDate,-35}");
        }
    }
}
