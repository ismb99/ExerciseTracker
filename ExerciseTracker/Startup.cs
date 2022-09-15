using ExerciseTracker.Models.Data;
using ExerciseTracker.Repository;
using ExerciseTracker.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
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

                .AddSingleton<IWorkoutRepository,WorkoutRepository>()
           .AddDbContext<WorkoutContext>(opt =>
                opt.UseSqlServer(@"Server=.;Database=ExerciseTracker;Trusted_Connection=True;"))
                .BuildServiceProvider();

            return provider;
        }


    }
}
