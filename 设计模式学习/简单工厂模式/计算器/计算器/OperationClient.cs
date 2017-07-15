using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算器
{
    class OperationClient
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.CreateOperation("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();

            Console.WriteLine("运算结果："+result.ToString());
            Console.ReadLine();
        }
    }
}
