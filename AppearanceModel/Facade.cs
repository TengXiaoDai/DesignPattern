using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceModel
{
    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
        }
        public void MethodA()
        {
            Console.WriteLine("方法组A()---");
            one.MethodOne();
        }
        public void MethodB()
        {
            Console.WriteLine("方法组B()---");
            one.MethodOne();
            two.MethodTwo();
        }
    }
}
