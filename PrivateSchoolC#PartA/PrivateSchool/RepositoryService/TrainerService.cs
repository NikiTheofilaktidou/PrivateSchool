using PrivateSchool.Database;
using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.RepositoryService
{
    public class TrainerService
    {
        MyDatabase db = new MyDatabase();

        public List<Trainer> GetTrainers()
        {
            return db.Trainers;
        }
        public Trainer GetTrainer(int a)
        {
            var trainer = db.Trainers.Find(x => x.TrainerId == a);
            return trainer;
        }
        public void CreateTrainer(Trainer trainer)
        {
            int lastId = db.Trainers[db.Trainers.Count - 1].TrainerId;
            trainer.TrainerId = lastId + 1;
            db.Trainers.Add(trainer);
        }
        public void RelateTrainerWithCourse(Trainer trainer, Course course)
        {
            trainer.Courses.Add(course);
            course.Trainers.Add(trainer);
        }
    }
}