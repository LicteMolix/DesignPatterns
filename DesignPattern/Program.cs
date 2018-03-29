using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.SimpleFactory;//使用简单工厂模式

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 40;
            int number2 = 20;
            Factory factory = new Factory();//创建一个工厂
            Calculate cal = factory.CreateCal('*',number1,number2);//使用需求对应创建需要的类
            Console.WriteLine(cal.CalculateOp());
            Console.ReadKey();
        }
    }
}
