using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterModel
{
    public class Adapter:Target
    {
        private Adaptee adaptee;
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
