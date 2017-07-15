using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口隔离原则练习
{
    public class Searcher : AbstractSearcher
    {
        public Searcher(IGoodbodyPettyGirl _pettyGirl)
        {
            base.goodbodypettyGirl = _pettyGirl;
        }

        public Searcher(IGreatTemperamentGirl _pettyGirl)
        {
            base.greatTemperamentGirl= _pettyGirl;
        }
        public Searcher()
        { 
        }
      

        public override void show()
        {
            System.Console.WriteLine("-------------美女的信息如下：---------------");
            try
            {
                if (base.goodbodypettyGirl != null)
                {
                    //展示面容
                    base.goodbodypettyGirl.goodLooking();

                    //展示身材
                    base.goodbodypettyGirl.niceFigure();
                }
                if (base.greatTemperamentGirl != null)
                {
                    //展示气质
                    base.greatTemperamentGirl.greatTemperament();
                }
            }
            catch (Exception ex)
            { 
            }


        }
    }
}
