using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class WeatherData : ISubjectAKAObservable
    {
        private ArrayList observers;
        private float temprature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void NofifyObserver()
        {
            foreach (IObserverAKASubscriber  observer in observers)
            {
                observer.Update(temprature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserverAKASubscriber o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserverAKASubscriber o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
            {
                observers.Remove(o);
            }
        }

        public void MesurementChanged()
        {
            NofifyObserver();
        }

        public void SetMeasurements(float temprature, float humidity, float pressure)
        {
            this.temprature = temprature;
            this.humidity = humidity;
            this.pressure = pressure;
            MesurementChanged();
        }
    }
}
