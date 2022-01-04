using PrivateSchool.Database;
using PrivateSchool.Entities;
using System;
using System.Collections.Generic;

namespace PrivateSchool.RepositoryService
{
    public class AssignmentService
    {
        MyDatabase db = new MyDatabase();

        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }       
        public List<Assignment> GetAssignmentsOfWeek(List<DateTime> dates)
        {
            List<Assignment> assignmentsOfWeek = new List<Assignment>();
            foreach (var date in dates)
            {
                foreach (var assignment in db.Assignments)
                {
                    if (date == assignment.SubmissionDate)
                    {
                        assignmentsOfWeek.Add(assignment);
                    }
                }
            }
            return assignmentsOfWeek;
        }
        public Assignment GetAssignment(int a)
        {
            var assignment = db.Assignments.Find(x => x.AssignmentId == a);
            return assignment;
        }
        public void CreateAssignment(Assignment assignment)
        {
            int lastId = db.Assignments[db.Assignments.Count - 1].AssignmentId;
            assignment.AssignmentId = lastId + 1;
            db.Assignments.Add(assignment);
        }
        public void RelateAssignmentWithCourse(Assignment assignment, Course course)
        {
            assignment.Course=course;
            course.Assignments.Add(assignment);
        }
        public void RelateAssignmentWithStudent(Assignment assignment, Student student)
        {
            student.Assignments.Add(assignment);
            assignment.Students.Add(student);
        }
    }
}
