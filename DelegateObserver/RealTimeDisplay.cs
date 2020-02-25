using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateObserver
{
    public class RealTimeDisplay : Observer
    {
        private ClockSubject clock;

        public RealTimeDisplay()
        {
            this.clock = new ClockSubject();
            this.clock.Register(this);
        }

        public Action<string, int, int> Action;

        public void Update()
        {
            Action?.Invoke($"DelegateObserver: {this.clock.SignalTime}", 2, 7);
        }

        public void Close()
        {
            this.clock.EndTimer();
        }
    }
}
