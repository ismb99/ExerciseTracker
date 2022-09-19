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
            var workout = _context.Workout.FirstOrDefault(x => x.Id == id);
            if (workout != null)
            {
                _context.Workout.Remove(workout);
                _context.SaveChanges();
            }
            return workout;

        }

        public List<Workout> GetAllWorkouts()
        {
            return _context.Workout.ToList();
        }

        public Workout GetWorkoutById(int id)
        {
            
            throw new NotImplementedException();

        }


        public Workout Update(Workout workout)
        {
            _context.Workout.Update(workout);
            _context.SaveChanges();

            return workout;


        }
    }
}
