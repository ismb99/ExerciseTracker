using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker.Models.Data
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options) : base(options)
        {
        }
        public DbSet<Workout> Workout { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Server=(localdb)\\Local;Initial Catalog=PhoneBook; Integrated Security=True");
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=WorkoutLogger;Trusted_Connection=True;");
        //}
    }
}
