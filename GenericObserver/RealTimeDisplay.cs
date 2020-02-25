using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObserver
{
    public class RealTimeDisplay : Observer<DateTime>
    {
        public Action<string, int, int> Action;

        public void Update(DateTime signalTime)
        {
            Action?.Invoke($"GenericObserver: {signalTime}", 2, 8);
        }
    }
}
