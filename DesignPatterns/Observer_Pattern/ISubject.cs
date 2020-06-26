using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public interface ISubjectAKAObservable
    {
        void RegisterObserver(IObserverAKASubscriber o);
        void RemoveObserver(IObserverAKASubscriber o);
        void NofifyObserver();
    }
}
