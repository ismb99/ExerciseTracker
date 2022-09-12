using ExerciseTracker.Repository;
using ExerciseTracker.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    public class Startup
    {
        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddTransient<IWorkoutRepository, WorkoutRepository>()
                .BuildServiceProvider();    

                return provider;
        }
    }
}
