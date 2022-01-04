using PrivateSchool.Database;
using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.Views.Students;

namespace PrivateSchool.RepositoryService
{
    public class StudentService
    {
        MyDatabase db = new MyDatabase();

        public List<Student> GetStudents()
        {
            return db.Students;
        }
        public Student GetStudent(int a)
        {
            var student = db.Students.Find(x => x.StudentId == a);
            return student;
        }
        public void CreateStudent(Student student)
        {
            int lastId = db.Students[db.Students.Count - 1].StudentId;
            student.StudentId = lastId + 1;
            db.Students.Add(student);
        }
        public void RelateStudentWithCourse(Student student, Course course)
        {
            student.Courses.Add(course);
            course.Students.Add(student);
        }
    }
}
