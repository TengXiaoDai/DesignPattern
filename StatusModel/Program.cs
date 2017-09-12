using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //状态模式
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
        }
    }
}
