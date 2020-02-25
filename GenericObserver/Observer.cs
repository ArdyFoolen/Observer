using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObserver
{
    // Push-You observer pattern
    //  - Push-You: RealTimeDisplay gets the data from Clock through parameters in its Update method
    // RealTimeDisplay does not know anything about clocks
    // Clock violates Single Responsibility because it has to call notify and knows how to register

    public interface Observer<T>
    {
        void Update(T data);
    }
}
