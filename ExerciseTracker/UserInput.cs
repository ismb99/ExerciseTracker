using ExerciseTracker.Controllers;
using ExerciseTracker.Repository.IRepository;
using ExerciseTracker.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    public class UserInput
    {
        //ExerciseController exerciseController = new ExerciseController();

        //public void ShowMenu()
        //{

        //    Console.WriteLine("\n");
        //    Console.WriteLine(@"What would you like todo ? Choose from the options below:
        //    1 - Create a Workout
        //    2 - Delete a Workout
        //    3 - Update a Workout
        //    4 - View all Workouts
        //    5 - Show Workout by id
        //    6 - Quit");
        //    Console.WriteLine("----------------------------------------------");
        //    Console.WriteLine("\n\n");

        //    string userChoice = Console.ReadLine();

        //    switch (userChoice)
        //    {
        //        case "1":
        //            ProcessAdd();
        //            break;

        //        case "2":
        //            //ProcessDelete
        //            break;

        //        case "3":
        //            //ProcessUpdate
        //            break;

        //        case "4":
        //            //GetAll
        //            break;

        //        case "5":
        //            //GetById
        //            break;

        //        default:
        //            break;
        //    }
        //}

        //private void ProcessAdd()
        //{


        //    Console.Write("Type the  date, or 0 to return to main menu: ");
        //    string dateStart = Console.ReadLine();


        //    Console.Write("Type the  date, or 0 to return to main menu: ");
        //    string dateEnd = Console.ReadLine();

        //    Console.Write("Type hours you worktout, or 0 to return to main menu: ");
        //    string duration = Console.ReadLine();

        //    Console.Write("Write comment, or 0 to return to main menu: ");
        //    string comment = Console.ReadLine();
        //}


        public static DateTime GetStartDateInput()
        {
            DateTime startTime;

            Console.Write("\nInsert start time format (yyyy-mm-dd HH:mm) or press 0 to return to main menu: ");
            var dateStart = Console.ReadLine();

            while (!DateTime.TryParseExact(dateStart, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime))
            {
                Console.WriteLine("\n\nInvalid date. (Format: yyyy-mm-dd hh:mm). Type 0 to return to main manu or try again:\n\n");
                dateStart = Console.ReadLine();
            }
            return startTime;
        }

        public static DateTime GetEndDateInput()
        {
            DateTime endTime;

            Console.Write("\nInsert end time format (yyyy-mm-dd HH:mm) or press 0 to return to main menu: ");
            var dateEnd = Console.ReadLine();


            while (!DateTime.TryParseExact(dateEnd, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime))
            {
                Console.WriteLine("\n\nInvalid date. (Format: yyyy-mm-dd hh:mm). Type 0 to return to main manu or try again:\n\n");
                dateEnd = Console.ReadLine();
            }

            return endTime;
        }

        public static TimeSpan CalculateDuration()
        {
            var start = GetStartDateInput();
            var end = GetEndDateInput();

            var duration = end - start;

            return duration;
        }
    }
}
