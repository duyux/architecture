using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
             const string VipString="VIP_";
             string str = string.Format(VipString+"{0}","001");
             Console.WriteLine(str);
             Console.ReadKey();
        }
    }
}
