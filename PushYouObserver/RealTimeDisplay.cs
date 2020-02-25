using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushYouObserver
{
    public class RealTimeDisplay : Observer
    {
        public Action<string, int, int> Action;

        public void Update(DateTime signalTime)
        {
            Action?.Invoke($"PushYouObserver: {signalTime}", 2, 6);
        }
    }
}
