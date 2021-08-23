using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Factories
{
#nullable enable
    public class PoultryFactory<T> : IPoultryFactory<T>
    {
        public T? CreateDTO()
        {
            if (typeof(T) == typeof(IChickenDTO) || typeof(IChickenDTO).IsAssignableFrom(typeof(T)))
            {
                return (T)(object)new ChickenDTO();
            }
            if (typeof(T) == typeof(IDuckDTO) || typeof(IDuckDTO).IsAssignableFrom(typeof(T)))
            {
                return (T)(object)new DuckDTO();
            }
            if (typeof(T) == typeof(IGooseDTO) || typeof(IGooseDTO).IsAssignableFrom(typeof(T)))
            {
                return (T)(object)new GooseDTO();
            }
            else
            {
                return default(T);
            }
        }

    }
#nullable disable
}
