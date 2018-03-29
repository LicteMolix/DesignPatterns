using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    class SubtractionClass : Calculate
    {
        public SubtractionClass(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public override int CalculateOp()
        {
            return Number1 - Number2;
        }
    }
}
