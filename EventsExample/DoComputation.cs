using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsExample
{
    class DoComputation
    {
        // 1.Define a delegate
        // 2.Define Events on that Delegate
        // 3.Raise the Event

        public delegate void ComputedEventHandeler(object origin, EventArgs args);

        public event ComputedEventHandeler Computed;

        public void Compute(Computation computation)
        {
            Console.WriteLine("Doing Some Computation...for " + computation.Title);
            Thread.Sleep(2000);

            OnComputed();
        }

        protected virtual void OnComputed()
        {
            if(Computed != null)
            {
                Computed(this, EventArgs.Empty);
            }
        }

    }
}
