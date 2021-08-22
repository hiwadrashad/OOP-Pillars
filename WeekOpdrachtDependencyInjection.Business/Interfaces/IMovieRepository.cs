using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface IMovieRepository
    {
        public void Add(Movie movie);
    }
}
