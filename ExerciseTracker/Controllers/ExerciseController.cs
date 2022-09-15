using ExerciseTracker.Models;
using ExerciseTracker.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Controllers
{
    public class ExerciseController
    {

        private readonly IWorkoutRepository _workoutRepostitory;

        public ExerciseController(IWorkoutRepository workoutRepostitory)
        {
            _workoutRepostitory = workoutRepostitory;
        }

        public void Post()
        {
            Console.Write("Type the  date, or 0 to return to main menu: ");
            string date = Console.ReadLine();

            Console.Write("Type hours you worktout, or 0 to return to main menu: ");
            string time = Console.ReadLine();

            Console.Write("Write comment, or 0 to return to main menu: ");
            string comment = Console.ReadLine();

            var workoutObj = new Workout()
            {
                Date = date,
                Time = time,
                Comments = comment
            };
            _workoutRepostitory.Add(workoutObj);
        }
    }
}
