using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    class DivisionClass : Calculate
    {
        public DivisionClass(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public override int CalculateOp()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("error");
                return 0;
            }
            else
            {
                return Number1 / Number2;
            }
        }
    }
}
