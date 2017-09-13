using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgingModel.Demo
{
    public class MacCompater : CompaterCard
    {
        public MacCompater(CompaterFunction function) : base(function)
        {
        }

        public override void Run()
        {
            base.function.Function();
        }
    }
}
