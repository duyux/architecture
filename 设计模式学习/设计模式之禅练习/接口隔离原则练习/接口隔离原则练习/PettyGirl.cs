using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口隔离原则练习
{
    public class PettyGirl : IGoodbodyPettyGirl, IGreatTemperamentGirl
    {
        private String name;
        //美女都有名字
        public PettyGirl(String _name)
        {
            this.name = _name;
        }
        
        //脸蛋漂亮
        public void goodLooking()
        {
            System.Console.WriteLine(this.name +"---脸蛋很漂亮！");
        }

        //身材要好
        public void niceFigure()
        {
            System.Console.WriteLine(this.name + "---身材非常棒！");
        }

        //气质要好
        public void greatTemperament()
        {
            System.Console.WriteLine(this.name + "---气质非常好！");
        }
    }
}
