using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class WeatherData : ISubject
    {
        private ArrayList observer;
        private float temprature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observer = new ArrayList();
        }

        public void NofifyObserver()
        {
            foreach (IObserver observer in observer)
            {
                observer.Update(temprature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observer.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int i = observer.IndexOf(o);
            if (i >= 0)
            {
                observer.Remove(o);
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
