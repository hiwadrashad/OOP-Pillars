using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class DuckDTO : BirdABSTR, IDuckDTO
    {
        public override string Sound()
        {
            return "Quack";
        }
    }
}
