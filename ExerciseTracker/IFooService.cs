using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    public interface IFooService
    {
        void DoSomeWork(int i);
    }

    public class FooService : IFooService
    {
        public void DoSomeWork(int i)
        {
            Console.WriteLine($"Processing {i}");
        }
    }
}
