using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    public class ConcreteStrategyA:Strategy
    {
        public override void AlgoristhmInterface()
        {
            Console.WriteLine("实现算法A");
        }
    }
}
