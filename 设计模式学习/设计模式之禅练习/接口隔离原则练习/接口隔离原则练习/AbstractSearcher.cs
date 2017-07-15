using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口隔离原则练习
{
    public abstract class AbstractSearcher
    {
        protected IGoodbodyPettyGirl goodbodypettyGirl;
        protected IGreatTemperamentGirl greatTemperamentGirl;
        public AbstractSearcher(IGoodbodyPettyGirl _goodbodypettyGirl)
        {
            this.goodbodypettyGirl = _goodbodypettyGirl;
        }

        public AbstractSearcher(IGreatTemperamentGirl _greatTemperamentGirl)
        {
            this.greatTemperamentGirl = _greatTemperamentGirl;
        }
        public AbstractSearcher()
        {

        }

        public IGoodbodyPettyGirl IGoodbodyPettyGirl
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public IGreatTemperamentGirl IGreatTemperamentGirl
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
      

        //搜索美女，列出美女信息
        public abstract void show();
    }
}
