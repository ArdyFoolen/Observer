using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateObserver
{
    // Push-You observer pattern
    //  - Push-You: RealTimeDisplay gets the data from Clock through parameters in its Update method
    // RealTimeDisplay does not know anything about clocks
    // Clock Does not violate Single Responsibility

    public interface Observer<T>
    {
        void Update(T data);
    }
}
