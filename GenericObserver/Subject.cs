using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObserver
{
    public abstract class Subject<T>
    {
        private List<Observer<T>> observers = new List<Observer<T>>();

        public void Register(Observer<T> observer)
        {
            this.observers.Add(observer);
        }

        public void Unregister(Observer<T> observer)
        {
            this.observers.Remove(observer);
        }

        protected void Notify(T data)
        {
            foreach (Observer<T> observer in this.observers)
                observer.Update(data);
        }
    }
}
