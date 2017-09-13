using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgingModel
{
    public abstract class PhoneCard
    {
        public PhoneFunction PhoneFunction { get; set; }
        public PhoneCard(PhoneFunction PhoneFunction)
        {
            this.PhoneFunction = PhoneFunction;
        }
        public abstract void Run();
    }
}
