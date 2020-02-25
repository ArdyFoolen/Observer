using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateObserver
{
    public interface Subject<T>
    {
        void Register(Observer<T> observer);
        void Unregister(Observer<T> observer);
        void Notify(T data);
    }
}
