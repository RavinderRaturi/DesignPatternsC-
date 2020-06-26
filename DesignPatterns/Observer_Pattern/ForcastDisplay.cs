using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class ForcastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private ISubject weatherData;

        public ForcastDisplay(ISubject weatherData) {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public object Display()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Forecast: ");

            if (currentPressure > lastPressure)
            {
                sb.Append("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                sb.Append("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                sb.Append("Watch out for cooler, rainy weather");
            }
            return sb.ToString();
        }

        public void Update(float temprature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
        }
    }
}
