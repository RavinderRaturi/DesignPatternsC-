using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class CurrentConditionsDisplay : IObserverAKASubscriber, IDisplayElement
    {

        private float temperature;
//teseting
        private float humidity;
        private float pressure;
        private ISubjectAKAObservable weatherData;

        public CurrentConditionsDisplay(ISubjectAKAObservable weatherData) {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }


        public object Display()
        {
            return "Current conditions: " + temperature +
                    "F degrees and " + humidity + "% humidity";
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}
