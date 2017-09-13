using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgingModel
{
    public class Android : PhoneCard
    {
        public Android(PhoneFunction PhoneFunction) : base(PhoneFunction)
        {
        }

        public override void Run()
        {
            base.PhoneFunction.Run();
        }
    }
}
