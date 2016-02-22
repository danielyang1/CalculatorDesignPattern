using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern
{
    class Add : ICalculate
    {
        public double calculate(double first, double second)
        {
            double sum = first + second;
            return sum;
        }
    }
}
