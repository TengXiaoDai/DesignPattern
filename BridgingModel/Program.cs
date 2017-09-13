using BridgingModel.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgingModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //桥连模式
            Android android = new Android(new VieoFunction());
            android.Run();

            MacCompater Mac = new MacCompater(new WatchFunction());
            Mac.Run();

        }
    }
}
