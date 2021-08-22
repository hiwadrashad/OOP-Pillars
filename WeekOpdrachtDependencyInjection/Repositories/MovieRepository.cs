using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using WeekOpdrachtDependencyInjection.DataBase;

namespace WeekOpdrachtDependencyInjection.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviesDataBase _moviesDataBase;
        public MovieRepository(MoviesDataBase moviesDatabase)
        {
            _moviesDataBase = moviesDatabase;
        }

        public void Add(Movie movie)
        {
            _moviesDataBase.Movies.Add(movie);
            _moviesDataBase.SaveChanges();
        }
    }
}
