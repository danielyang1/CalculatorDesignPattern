using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern
{
    class Subtract : ICalculate
    {
        public double calculate(double first, double second)
        {
            double answer = first - second;
            return answer;
        }
    }
}
