using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 迪米特法则
{
    public class Teacher
    {
        public GroupLeader GroupLeader
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Commond(GroupLeader groupLeader)
        {
            throw new System.NotImplementedException();
        }
    }
}
