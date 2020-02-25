using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardObserver
{
    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Register(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void Unregister(Observer observer)
        {
            this.observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (Observer observer in this.observers)
                observer.Update();
        }
    }
}
