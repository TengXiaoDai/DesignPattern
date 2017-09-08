using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationModel
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplePhone Template = new ApplePhone();
            Accessories a=new Accessories();
            a.DecoratorObj(Template);
            a.Print();
            Console.ReadKey();
        }
    }
}
