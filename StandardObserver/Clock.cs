using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StandardObserver
{
    public class Clock : Subject
    {
        Timer timer = new Timer();
        public DateTime SignalTime;

        public Clock()
        {
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer.Interval = 750;
            timer.Enabled = true;

            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        protected virtual void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.SignalTime = e.SignalTime;
            Notify();
        }

        public void EndTimer()
        {
            timer.Stop();
            this.timer.Close();
        }
    }
}
