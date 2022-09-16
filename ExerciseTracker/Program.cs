using ExerciseTracker;
using ExerciseTracker.Repository.IRepository;
using Microsoft.Extensions.DependencyInjection;


var container = Startup.ConfigureService();


var workoutService = container.GetService<IWorkoutRepository>();
workoutService.hello();








