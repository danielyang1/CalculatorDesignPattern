using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern
{
    class Powers:ICalculate
    {
        public double calculate(double first, double second)
        {
            double answer = Math.Pow(first, second);
            return answer;
        }
    }
}
