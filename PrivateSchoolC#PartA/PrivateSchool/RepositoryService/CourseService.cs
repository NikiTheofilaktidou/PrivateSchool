using PrivateSchool.Database;
using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.RepositoryService
{
    public class CourseService
    {
        MyDatabase db = new MyDatabase();

        public List<Course> GetCourses()
        {
            return db.Courses;
        }
        public Course GetCourse(int a)
        {
            var course = db.Courses.Find(x => x.CourseId == a);
            return course;
        }
        public void CreateCourse(Course course)
        {
            int lastId = db.Courses[db.Courses.Count - 1].CourseId;
            course.CourseId = lastId + 1;
            db.Courses.Add(course);
        }
    }
}
