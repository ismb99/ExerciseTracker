using ExerciseTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Repository.IRepository
{
    public interface IWorkoutRepository
    {
        Workout GetWorkoutById(int id);
        IEnumerable<Workout> GetAllWorkouts();
        Workout Add(Workout workout);
        Workout Update(Workout workout);
        Workout Delete(int id);
        void hello();
    }
}
