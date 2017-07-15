using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口隔离原则练习
{
    class Client
    {
        //搜索并展示美女信息
        static void Main(string[] args)
        {
            
            //定义一个美女
            IGoodbodyPettyGirl yanYan = new PettyGirl("燕燕");
            //IGreatTemperamentGirl yanYan = new PettyGirl("燕燕");
            AbstractSearcher searcher = new Searcher(yanYan);
            searcher.show();

            System.Console.ReadKey();

        }
    }
}
