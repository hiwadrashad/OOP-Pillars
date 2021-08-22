using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;

namespace WeekOpdrachtDependencyInjection.DataBase
{
    public class MoviesDataBase : DbContext
    {
        public MoviesDataBase(DbContextOptions<MoviesDataBase> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}
