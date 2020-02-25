using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DelegateObserver
{
    public class ClockSubject : Clock
    {
        private Subject subject;

        public ClockSubject()
        {
            this.subject = new SubjectImpl();
        }

        private void Notify()
        {
            this.subject.Notify();
        }

        public void Register(Observer observer)
        {
            this.subject.Register(observer);
        }

        public void Unregister(Observer observer)
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
