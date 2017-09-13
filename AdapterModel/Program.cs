using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //适配器模式
            Target traget = new Adapter();
            traget.Request();
        }
    }
}
