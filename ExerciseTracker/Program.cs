using ExerciseTracker;
using ExerciseTracker.Controllers;
using ExerciseTracker.Models.Data;
using ExerciseTracker.Repository;
using ExerciseTracker.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


class Program
{
    static void Main(string[] args)
    {

        var host = CreateHostBuilder(args).Build();

        host.Services.GetService<IWorkoutRepository>();

        
        var workoutRepository = host.Services.GetService<IWorkoutRepository>();


        //ExerciseController excerciseController = new ExerciseController(workoutRepository);

        
        
        
       
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        var hostBuilder = Host.CreateDefaultBuilder(args)

            .ConfigureServices((context, services) =>
            {
                services.AddScoped<IWorkoutRepository, WorkoutRepository>();
                services.AddDbContext<WorkoutContext>(options => options.UseSqlServer("Server=.;Database=ExerciseTracker;Trusted_Connection=True"));
            });

        return hostBuilder;
    }
}

