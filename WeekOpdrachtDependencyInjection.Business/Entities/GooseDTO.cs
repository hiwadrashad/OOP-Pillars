using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class GooseDTO : BirdABSTR, IGooseDTO
    {
        public override string Sound()
        {
            return "Honk";
        }
    }
}
