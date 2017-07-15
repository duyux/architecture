using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 计算器
{
    class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OpertionDiv();
                    break;
            }
            return oper;
        }
    }
}
