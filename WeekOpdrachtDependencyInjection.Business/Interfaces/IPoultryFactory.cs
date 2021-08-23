using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
#nullable enable
    public interface IPoultryFactory<T>
    {
        public T? CreateDTO();
    }
#nullable disable
}
