using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Business.Strategy
{
    public class PiStrategy : IPiStrategy
    {
        private ICalculateAddingService _calculateAddingService;

        public PiStrategy()
        {
        }

        public PiStrategy(ICalculateAddingService calculateAddingService)
        {
            this._calculateAddingService = calculateAddingService;
        }

        public void SetStrategy(ICalculateAddingService calculateAddingService)
        {
            if (this._calculateAddingService == null)
            {
                this._calculateAddingService = calculateAddingService;
            }
        }

        public double Add(int input)
        {
            return _calculateAddingService.Add(input);
        }

        public double Substract(int input)
        {
            return _calculateAddingService.Minus(input);
        }

        public (double? AddResult, double? SubstractResult) AddAndSubstractRespectivaly(Func<int, double> Add, Func<int, double> Substract, int Input)
        {
            var addresult = Add?.Invoke(Input);
            var substractersult = Substract?.Invoke(Input);
            return (addresult, substractersult);
        }
    }
}
