using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardObserver
{
    // Standard Pull-Me observer pattern
    //  - Pull-Me: RealTimeDisplay gets the data from Clock in its Update method
    // Clock violates Single Responsibility because it has to call notify and knows how to register

    public interface Observer
    {
        void Update();
    }
}
