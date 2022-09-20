using ExerciseTracker.Models;
using ExerciseTracker.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        //public void Home()
        //{
        //    var workout= ShowMenu();
        //}

        public void Post(Workout workout)
        {
            _workoutRepostitory.Add(workout);
        }

        public void Remove(int id)
        {
            _workoutRepostitory.Delete(id);
        }

        public void GetAll()
        {
            var workoutList = _workoutRepostitory.GetAllWorkouts().ToList();

            WorkoutVisualizer.ShowWorkouts(workoutList);
        }

        public void Put(Workout workout)
        {
            _workoutRepostitory.Update(workout);
        }

        public void GetById(int id)
        {
            var workout = _workoutRepostitory.GetWorkoutById(id);

            List<Workout> workouts = new List<Workout>();

            workouts.Add(workout);

            WorkoutVisualizer.ShowWorkouts(workouts);

        }

        public void ShowMenu() // ändra return typ (Adama)
        {
            //Workout userinputResult= new Workout();

            bool closeApp = true;

            while (closeApp != false)
            {

                Console.WriteLine("\n");
                Console.WriteLine(@"What would you like todo ? Choose from the options below:
            1 - Create a Workout
            2 - Delete a Workout
            3 - Update a Workout
            4 - View all Workouts
            5 - Show Workout by id
            6 - Quit");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\n\n");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        //userinputResult= ProcessAdd();
                        //Post(userinputResult);
                        //return userinputResult;
                        ProcessAdd();
                        break;


                    case "2":
                        //userinputResult=//ProcessDelete
                        ProcessDelete();
                        break;

                    //var nullWorkout= new Workout()
                    //{
                    // Skapa ett objekt med tomma värden om det inte skulle funka att returnera userinputResult
                    //    date= dateTime.Now()
                    //    comment = "",
                    //    
                    //}
                    //return userinputResult;

                    case "3":
                        ProcessUpdate();
                        break;
                    //return userinputResult;

                    case "4":
                        GetAll();
                        break;
                    //return userinputResult;

                    case "5":
                        ProcessGetById();
                        break;
                    //return userinputResult; 

                    case "6":
                        Console.WriteLine("App cloesed!");
                       closeApp = false;
                        break;
                    //return userinputResult; 

                    default:
                        Console.WriteLine("Wrong choice try again");
                        break;
                }
            }
        }

        private void ProcessGetById()
        {
            _workoutRepostitory.GetAllWorkouts();
            var id = UserInput.GetNumInput("Choose id: ");
            GetById(id);
        }

        private void ProcessUpdate()
        {
            GetAll();
            var id = UserInput.GetNumInput("Choose the id you want to update or press 0 for main menu:");
            var allWorkouts = _workoutRepostitory.GetAllWorkouts();

            var workOutId = allWorkouts.FirstOrDefault(x => x.Id == id);

            if (workOutId != null)
            {
                var startDate = UserInput.GetStartDateInput();
                var endDate = UserInput.GetEndDateInput();

                // validera så att man inte kan lägga in fel tid och datum

                Console.WriteLine("Add comments or press 0 to return to main menu");
                string comment = Console.ReadLine();

                while (string.IsNullOrEmpty(comment))
                {
                    Console.WriteLine("Comments can't be empty! Input your comment once more");
                    comment = Console.ReadLine();
                }
                TimeSpan duration = endDate - startDate;

                //var updatedWorkout = new Workout()
                //{
                //    DateStart = startDate,
                //    DateEnd = endDate,
                //    Comments = comment,
                //    Duration = duration
                //};

                workOutId.DateStart = startDate;
                workOutId.DateEnd = endDate;
                workOutId.Duration = duration;
                workOutId.Comments = comment;

                Put(workOutId);
            }
            else
            {
                Console.WriteLine("Workout dosent exsist");
            }
        }

        private void ProcessDelete()
        {
            GetAll();
            Console.Write("Choose the id you want to delete or press 0 for main menu: ");

            string userInput = Console.ReadLine();

            if (userInput == "0") ShowMenu();
            // Convert.ToInt32(userInput) < 0
            int id = int.Parse(userInput);

            Remove(id);
        }

        private void ProcessAdd()
        {
            // validera så att man inte kan lägga in fel tid och datum

            var startDate = UserInput.GetStartDateInput();
            var endDate = UserInput.GetEndDateInput();

            Console.Write("\nAdd comments or press 0 to return to main menu: ");
            string comment = Console.ReadLine();

            if (comment == "0") ShowMenu();

            while (string.IsNullOrEmpty(comment))
            {
                Console.WriteLine("\nComments can't be empty! Input your comment once more");
                comment = Console.ReadLine();
            }

            TimeSpan duration = endDate - startDate;

            var workoutObj = new Workout()
            {
                DateStart = startDate,
                DateEnd = endDate,
                Comments = comment,
                Duration = duration
            };
            Post(workoutObj);
        }
    }
}
