using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //原型模式
            ConcretePrototype p1 = new ConcretePrototype("001");
            ConcretePrototype p2 = (ConcretePrototype)p1.Clone();
            Console.WriteLine(p2.Id);
        }
    }
}
