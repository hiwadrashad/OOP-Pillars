﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Entities
{
    public class DuckDTO : BirdABSTR
    {
        public override string Sound()
        {
            return "Quack";
        }
    }
}
