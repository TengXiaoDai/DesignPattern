using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyModel
{
    //此为真实的追求者,与代理着必须都继承接口
    public class Pursuit : Interface
    {
        public BetifalGair BetifalGair { get; set; }
        public Pursuit(BetifalGair BetifalGair)
        {
            this.BetifalGair = BetifalGair;
        }
        public void Chocolates()
        {
            Console.WriteLine(BetifalGair.Name+"送你巧克力");
        }

        public void Flower()
        {
            Console.WriteLine(BetifalGair.Name+"送你的小花花");
        }
    }
}
