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

        public void Post( Workout workout)
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

        public void ShowMenu() // ändra return typ (Adama)
        {
            //Workout userinputResult= new Workout();

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
                    //GetById
                    //return userinputResult; 

                default:
                    //return userinputResult;
                    break;
            }
        }

        private void ProcessUpdate()
        {
            // Användare väljer ett id
            // 
            GetAll();
            Console.Write("Choose the id you want to update or press 0 for main menu: ");
            var allWorkouts = _workoutRepostitory.GetAllWorkouts();

            string userInput = Console.ReadLine();
            if (userInput == "0") ShowMenu();

            int id = int.Parse(userInput);

           var workOutId = allWorkouts.FirstOrDefault(x => x.Id == id);


         
            if (workOutId != null)
            {
                DateTime startTime;
                DateTime endTime;

                Console.Write("Insert start time format (yyyy-mm-dd HH:mm) or press 0 to return to main menu: ");
               
                var dateStart = Console.ReadLine();
                
                while (!DateTime.TryParseExact(dateStart, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime))
                {
                    Console.WriteLine("\n\nInvalid date. (Format: yyyy-mm-dd hh:mm). Type 0 to return to main manu or try again:\n\n");
                    dateStart = Console.ReadLine();
                }

                Console.Write("Insert end time format (yyyy-mm-dd HH:mm) or press 0 to return to main menu: ");
                var dateEnd = Console.ReadLine();

                if (dateEnd == "0") ShowMenu();


                while (!DateTime.TryParseExact(dateEnd, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime))
                {
                    Console.WriteLine("\n\nInvalid date. (Format: yyyy-mm-dd hh:mm). Type 0 to return to main manu or try again:\n\n");
                    dateEnd = Console.ReadLine();
                }

                // validera så att man inte kan lägga in fel tid och datum

                Console.WriteLine("Add comments or press 0 to return to main menu");
                string comment = Console.ReadLine();

                if (comment == "0") ShowMenu();

                while (string.IsNullOrEmpty(comment))
                {
                    Console.WriteLine("Comments can't be empty! Input your comment once more");
                    comment = Console.ReadLine();
                }
                TimeSpan duration = endTime - startTime;


                var updatedWorkout = new Workout()
                {
                    DateStart = startTime,
                    DateEnd = endTime,
                    Comments = comment,
                    Duration = duration
                };

                Put(updatedWorkout);
            }

            else
            {
                Console.WriteLine("Workout dosent exsist");
            }

        }

        private void ProcessDelete()
        {
            //var allWorkouts = _workoutRepostitory.GetAllWorkouts();
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
