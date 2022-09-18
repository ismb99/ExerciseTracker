using ConsoleTableExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    public class WorkoutVisualizer
    {
        public static void ShowWorkouts<T>(List<T> tableData) where T : class
        {
            Console.WriteLine("\n\n");

            ConsoleTableBuilder
                .From(tableData)
                .ExportAndWriteLine();
            Console.WriteLine("\n\n");
        }
    }
}
