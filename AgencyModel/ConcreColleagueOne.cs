using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyModel
{
    public class ConcreColleagueOne : Colleague
    {
        public ConcreColleagueOne(Mediator mediator) : base(mediator)
        {
        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("同事1得到的信息{0}",message);
        }
    }
}
