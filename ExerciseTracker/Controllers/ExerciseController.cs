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

        public void Home()
        {
            UserInput userInput = new();
            userInput.ShowMenu();


        }

        public void Post()
        {

            var workoutObj = new Workout()
            {
                DateStart = date,
                Time = time,
                Comments = comment
            };
            _workoutRepostitory.Add(workoutObj);
        }
    }
}
