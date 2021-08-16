using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoTest.Controllers;
using System.Collections.Generic;
using DemoTest;

namespace DemoTestUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WeatherForecast_List_Failed()
        {
            WeatherForecastController wc = new WeatherForecastController();
            //Assert
            var ct = wc.Get();
            int c = ((DemoTest.WeatherForecast[])ct).Length;
            int count = 4;

            Assert.AreEqual(c,count, "Count not matched");

            
        }

        [TestMethod]
        public void WeatherForecast_List_Succeded()
        {
            WeatherForecastController wc = new WeatherForecastController();
            //Assert
            var ct = wc.Get();
            int c = ((DemoTest.WeatherForecast[])ct).Length;
            int count = 5;

            Assert.AreEqual(c, count, "Count not matched");
        }

        [TestMethod]
        public void WeatherForecast_List_SummaryCheck()
        {
            WeatherForecastController wc = new WeatherForecastController();
            //Assert equal
            string summary = "Mild";
            var ct = wc.Get(summary);

            int c = ((DemoTest.WeatherForecast[])ct).Length;

            int expected = 1;

             Assert.AreEqual(c, expected, "Count matched the records");
        }
    }
}
