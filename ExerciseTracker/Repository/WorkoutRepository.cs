using ExerciseTracker.Models;
using ExerciseTracker.Models.Data;
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

        private readonly WorkoutContext _context;

        public WorkoutRepository(WorkoutContext context)
        {
            _context = context;
        }

    
        public Workout Add(Workout workout)
        {
            _context.Workout.Add(workout);
            _context.SaveChanges();

            return workout;
        }

        public Workout Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Workout> GetAllWorkouts()
        {
            return _context.Workout.ToList();
        }

        public Workout GetWorkoutById(int id)
        {
            throw new NotImplementedException();

        }


        public Workout Update(Workout workout)
        {
            throw new NotImplementedException();
        }
    }
}
