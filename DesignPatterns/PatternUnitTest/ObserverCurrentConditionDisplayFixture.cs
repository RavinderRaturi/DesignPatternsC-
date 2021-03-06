﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer_Pattern;
namespace PatternUnitTest
{
    [TestClass]
    public class ObserverCurrentConditionDisplayFixture
    {
        #region Members
        static WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentConditionsDisplay =
            new CurrentConditionsDisplay(weatherData);
        ForcastDisplay forcastDisplay = new ForcastDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        #endregion//Members

        #region TestCurrentConditionsDisplay
        [TestMethod]
        public void TestCurrentConditionsDisplay()
        {
            weatherData.SetMeasurements(80, 65, 30.4f);

            Assert.AreEqual("Current conditions: 80F degrees and 65% humidity",
                currentConditionsDisplay.Display());
        }
        #endregion//TestCurrentConditionsDisplay

        #region TestForecastDisplay
        [TestMethod]
        public void TestForecastDisplay()
        {
            weatherData.SetMeasurements(81, 63, 31.2f);
            //lastPressure = 29.92f
            Assert.AreEqual("Forecast: Improving weather on the way!",
                forcastDisplay.Display());

            weatherData.SetMeasurements(81, 63, 29.92f);
            Assert.AreEqual("Forecast: Watch out for cooler, rainy weather",
                forcastDisplay.Display());

            weatherData.SetMeasurements(81, 63, 29.92f);
            Assert.AreEqual("Forecast: More of the same",
                forcastDisplay.Display());
        }
        #endregion//TestForecastDisplay

        #region TestStatisticsDisplay
        [TestMethod]
        public void TestStatisticsDisplay()
        {
            weatherData.SetMeasurements(80, 63, 31.2f);
            weatherData.SetMeasurements(81, 63, 29.92f);
            weatherData.SetMeasurements(84, 63, 29.92f);
            Assert.AreEqual("Avg/Max/Min temperature = 81.67F/84F/80F",
                statisticsDisplay.Display());
        }
        #endregion//TestStatisticsDisplay
    }
}
