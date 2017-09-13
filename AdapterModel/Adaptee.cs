using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterModel
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊要求!");
        }
    }
}
