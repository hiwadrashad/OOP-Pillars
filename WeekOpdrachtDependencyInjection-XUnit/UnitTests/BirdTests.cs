using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Factories;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using Xunit;

namespace WeekOpdrachtDependencyInjection_XUnit.UnitTests
{
    
    public class BirdTests
    {



        [Fact]
        public void Goose_Honks_Test()
        {
            var MockFactory = new Mock<IPoultryFactory<IGooseDTO>>();
            GooseDTO DTO = new GooseDTO();
            MockFactory.Setup(a => a.CreateDTO()).Returns(DTO);
            Assert.Equal("Honk",MockFactory.Object.CreateDTO().Sound());
        }

        [Fact]
        public void Duck_Quacks_Test()
        {
            var MockFactory = new Mock<IPoultryFactory<IDuckDTO>>();
            DuckDTO DTO = new DuckDTO();
            MockFactory.Setup(a => a.CreateDTO()).Returns(DTO);
            Assert.Equal("Quack", MockFactory.Object.CreateDTO().Sound());
        }

        [Fact]
        public void Chicken_Clucks_Test()
        {
            var MockFactory = new Mock<IPoultryFactory<IChickenDTO>>();
            ChickenDTO DTO = new ChickenDTO();
            MockFactory.Setup(a => a.CreateDTO()).Returns(DTO);
            Assert.Equal("Cluck", MockFactory.Object.CreateDTO().Sound());
        }
    }
}
