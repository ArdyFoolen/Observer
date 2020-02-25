using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardObserver
{
    public class RealTimeDisplay : Observer
    {
        private Clock clock;

        public RealTimeDisplay()
        {
            this.clock = new Clock();
            this.clock.Register(this);
        }

        public Action<string, int, int> Action;

        public void Update()
        {
            Action?.Invoke($"StandardObserver: {clock.SignalTime}", 2, 5);
        }

        public void Close()
        {
            this.clock.EndTimer();
        }
    }
}
