using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SimpleFactory
{
    class Factory
    {
        Calculate cal;
        public Calculate CreateCal(char calchar,int number1,int number2)
        {
            switch (calchar) {
                case '+':cal = new AddClass(number1,number2);
                    break;
                case '-': cal = new SubtractionClass(number1, number2);
                    break;
                case '*': cal = new MultiplyClass(number1, number2);
                    break;
                case '/': cal = new DivisionClass(number1, number2);
                    break;
            }
            return cal;
        }
    }
}
