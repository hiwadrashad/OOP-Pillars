using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using Xunit;

namespace WeekOpdrachtDependencyInjection_XUnit.UnitTests
{
    public class MovieTest
    {
        [Fact]
        public void Verify_Adding_Is_Working_Test()
        {
            var MovieRepository = new Mock<IMovieRepository>();
            MovieRepository.Setup(a => a.Add(It.IsAny<Movie>())).Verifiable();
        }

        [Fact]
        public void Verify_Get_By_Id_Is_Working_Test()
        {
            var MovieRepository = new Mock<MovieService>();
            MovieRepository.Setup(a => a.Get(1)).Returns(new Movie { Id = 1, Title = "Jaws", ReleaseDate = new DateTime(1975, 1, 1) });
            Assert.Equal(1, MovieRepository.Object.Get(1).Id);
        }


        [Fact]
        public void Verify_Get_By_Name_Is_Working_Test()
        {
            var MovieRepository = new Mock<MovieService>();
            MovieRepository.Setup(a => a.Get("Jaws")).Returns(new Movie { Id = 1, Title = "Jaws", ReleaseDate = new DateTime(1975, 1, 1) });
            Assert.Equal(1, MovieRepository.Object.Get("Jaws").Id);
        }
    }
}
