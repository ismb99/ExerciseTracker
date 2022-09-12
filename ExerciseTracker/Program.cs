

using ExerciseTracker;
using Microsoft.Extensions.DependencyInjection;

var container = Startup.ConfigureService();

var barService = container.GetService<IBarService>();

barService.DoSomeRealWork();
