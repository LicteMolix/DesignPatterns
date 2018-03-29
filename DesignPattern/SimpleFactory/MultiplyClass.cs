using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    class MultiplyClass:Calculate
    {
        public MultiplyClass(int number1,int number2)
        {
            this.Number1 = number1;
            this.Number2 = number2;
        }

        public override int CalculateOp()
        {
            return Number1 * Number2;
        }
    }
}
