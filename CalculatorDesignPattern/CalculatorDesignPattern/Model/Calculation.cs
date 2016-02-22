using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDesignPattern
{
    class Calculation
    {
        string operatorInputed;
        string num1;
        string num2;
        public Calculation(string num1, string num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public ICalculate calculate() //my factory pattern
        {
            switch (operatorInputed)
            {
                case "+":
                    return new Add();
                case "-":
                    return new Subtract();
                case "*":
                    return new Multiply();
                case "/":
                    return new Divide();
                case "^":
                    return new Powers();
                default:
                    Console.WriteLine("Please Enter Valid Operator");
                    return new Add();
            }
        }
    }
}
