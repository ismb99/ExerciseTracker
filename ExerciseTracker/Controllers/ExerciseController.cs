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
            var workout= ShowMenu();

        }

        public void Post( Workout workout)
        {

            _workoutRepostitory.Add(workout);
        }

        public Workout ShowMenu()
        {
            Workout userinputResult= new Workout();

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
                    userinputResult= ProcessAdd();
                    Post(userinputResult);
                    return userinputResult;


                case "2":
                    //userinputResult=//ProcessDelete

                    //var nullWorkout= new Workout()
                    //{
                    // Skapa ett objekt med tomma värden om det inte skulle funka att returnera userinputResult
                    //    date= dateTime.Now()
                    //    comment = "",
                    //    
                    //}
                    return userinputResult;

                case "3":
                    //ProcessUpdate
                    return userinputResult;

                case "4":
                    //GetAll
                    return userinputResult;

                case "5":
                    //GetById
                    return userinputResult; ;

                default:
                    return userinputResult;
            }
        }

        private Workout ProcessAdd()
        {


            Console.Write("Type the  date, or 0 to return to main menu: ");
            var dateStart = Convert.ToDateTime(Console.ReadLine());


            Console.Write("Type the  date, or 0 to return to main menu: ");
            var dateEnd = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Type hours you worktout, or 0 to return to main menu: ");
            string duration = Console.ReadLine();

            Console.Write("Write comment, or 0 to return to main menu: ");
            string comment = Console.ReadLine();


            var workoutObj = new Workout()
            {
                DateStart = dateStart,
                DateEnd = dateEnd,
                Duration=dateEnd - dateStart,
                Comments=comment
            };

            return workoutObj;
        }
    }
}
