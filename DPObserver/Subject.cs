using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    interface Subject
    {
        void RegisterObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyObserver();

    }
}
