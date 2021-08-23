using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOpdrachtDependencyInjection.Business.Interfaces
{
    public interface IPiStrategy
    {
        public void SetStrategy(ICalculateAddingService calculateAddingService);
        public double Add(int input);
        public double Substract(int input);
        public (double? AddResult, double? SubstractResult) AddAndSubstractRespectivaly(Func<int, double> Add, Func<int, double> Substract, int Input);
    }
}
