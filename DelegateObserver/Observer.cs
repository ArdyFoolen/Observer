using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateObserver
{
    // Delegate observer pattern
    // RealTimeDisplay does not know anything about clocks
    // Clock does not violate Single Responsibility

    public interface Observer
    {
        void Update();
    }
}
