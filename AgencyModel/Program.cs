using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //中介者模式
            ConcreteMesiator m = new ConcreteMesiator();
            ConcreColleagueOne c = new ConcreColleagueOne(m);
            m.ConcreColleagueOne = c;
            c.Send("吃饭了吗？");
        }
    }
}
