using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using WeekOpdrachtDependencyInjection.Business.Strategy;
using Xunit;

namespace WeekOpdrachtDependencyInjection_XUnit.UnitTests
{
    public class PiTests
    {
        [Theory]
        [InlineData(-100)]
        [InlineData(0)]
        [InlineData(100)]
        public void Adding_To_Pi_Test(int value)
        {
            IPiStrategy Strategy = new PiStrategy();

            // |
            // |  Faulty Result
            // V

            //var MockStrategy = new Mock<IPiStrategy>();
            //MockStrategy.Setup(a => a.SetStrategy(new CalculatePiService()));
            //MockStrategy.Object.SetStrategy(new CalculatePiService());
            //MockStrategy.Setup(a => a.Add(0)).Returns(Math.PI);

            Strategy.SetStrategy(new CalculatePiService());

            Assert.Equal(Math.PI + value, Strategy.Add(value));

        }

        [Theory]
        [InlineData(-100)]
        [InlineData(0)]
        [InlineData(100)]
        public void Substracting_From_Pi_Test(int value)
        {
            IPiStrategy Strategy = new PiStrategy();

            Strategy.SetStrategy(new CalculatePiService());

            Assert.Equal(Math.PI - value, Strategy.Substract(value));

        }
    }
}
