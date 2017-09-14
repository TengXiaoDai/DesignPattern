using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyModel
{
    public class ConcreteMesiator : Mediator
    {
        public ConcreColleagueOne ConcreColleagueOne { get; set; }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == ConcreColleagueOne)
            {
                ConcreColleagueOne.Notify(message);
            }
            else
            {
                Console.WriteLine("不存在!");
            }
        }
    }
}
