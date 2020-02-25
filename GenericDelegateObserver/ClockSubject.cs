using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GenericDelegateObserver
{
    public class ClockSubject : Clock
    {
        private Subject<DateTime> subject;

        public ClockSubject()
        {
            this.subject = new SubjectImpl<DateTime>();
        }

        private void Notify()
        {
            this.subject.Notify(this.SignalTime);
        }

        public void Register(Observer<DateTime> observer)
        {
            this.subject.Register(observer);
        }

        public void Unregister(Observer<DateTime> observer)
        {
            this.subject.Unregister(observer);
        }

        protected override void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            base.timer_Elapsed(sender, e);
            this.Notify();
        }
    }
}
