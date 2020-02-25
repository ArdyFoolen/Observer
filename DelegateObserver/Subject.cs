using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateObserver
{
    public interface Subject
    {
        void Register(Observer observer);
        void Unregister(Observer observer);
        void Notify();
    }
}
