using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyModel
{
    //抽象同事类
    public abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
