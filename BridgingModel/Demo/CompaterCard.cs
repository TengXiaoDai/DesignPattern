using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgingModel.Demo
{
    public abstract class CompaterCard
    {
        public CompaterFunction function { get; set; }
        public CompaterCard(CompaterFunction function)
        {
            this.function = function;
        }
        public abstract void Run();
    }
}
