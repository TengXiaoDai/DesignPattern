using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyModel
{
    public class Proxy : Interface
    {
        public Pursuit pursuit { get; set; }
        public Proxy(BetifalGair betifalGair)
        {
            pursuit = new Pursuit(betifalGair);
        }
        public void Chocolates()
        {
            pursuit.Chocolates();
        }

        public void Flower()
        {
            pursuit.Flower();
        }
    }
}
