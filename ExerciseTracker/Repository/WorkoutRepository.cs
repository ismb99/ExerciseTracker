using ExerciseTracker.Models;
using ExerciseTracker.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Repository
{
    public class WorkoutRepository : IWorkoutRepository
    {
        public Workout Add(Workout workout)
        {
            throw new NotImplementedException();
        }

        public Workout Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Workout> GetAllWorkouts()
        {
            throw new NotImplementedException();
        }

        public Workout GetWorkout(int id)
        {
            throw new NotImplementedException();
        }

        public Workout Update(Workout workout)
        {
            throw new NotImplementedException();
        }
    }
}
