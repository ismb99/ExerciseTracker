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
        //
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

        // .................

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

        public static int GetNumInput(string message)
        {
            Console.Write("Inster a number: ");
            var numAsString = Console.ReadLine();

            int num;
            while (!int.TryParse(numAsString, out num))
            {
                Console.WriteLine("This is not a number!");
                numAsString = Console.ReadLine();
            }

            return num;
        }
    }
}
