using ExerciseTracker.Models.Data;
using ExerciseTracker.Repository;
using ExerciseTracker.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }


        public static IServiceProvider ConfigureService()
        {
            var provider = new ServiceCollection()
                .AddTransient<IWorkoutRepository, WorkoutRepository>()
                .AddDbContext<WorkoutContext>(
                options => options.UseSqlServer("Server=.;Database=ExerciseTracker;Trusted_Connection=True"))

                .BuildServiceProvider();

            return provider;
        }


        //public  void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<WorkoutContext>(opt =>
        //       opt.UseSqlServer(Configuration);
        //}


        //opt.UseSqlServer(@"Server=.;Database=ExerciseTracker;Trusted_Connection=True;"))
    }
}
