using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseTracker
{
    public interface IBarService
    {
        void DoSomeRealWork();
    }



    public class BarService : IBarService
    {
        private readonly IFooService _fooService;
       
        public BarService(IFooService fooService)
        {
            _fooService = fooService;
        }

        public void DoSomeRealWork()
        {
            for (int i = 0; i < 5; i++)
            {
                _fooService.DoSomeWork(i);
            }
        }
    }
}
