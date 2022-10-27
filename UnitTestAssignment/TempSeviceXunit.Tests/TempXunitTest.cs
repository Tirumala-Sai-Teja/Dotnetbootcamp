using System;
using Xunit;
using System.Text;
using Xunit.Sdk;

namespace TempService.test
{
    public class TempXUnitTest
    {
        [Fact]
        public void TestCtoF()
        {
            Temp d = new Temp();
            double actual = d.CelsiusToFahrenheit(30);
           
            Assert.Equal(86,actual);
        }
        [Fact]
        public void TestFToC()
        {
            Temp t = new Temp();
            double actual = t.FahrenheitToCelsius(86);
           
            Assert.Equal(30, actual);

        }

    }
}
