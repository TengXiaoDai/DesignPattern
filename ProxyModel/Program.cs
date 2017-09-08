using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            BetifalGair gair = new BetifalGair();
            gair.Name = "娇娇";
            Proxy proxy = new Proxy(gair);
            proxy.Flower();
        }
    }
}
