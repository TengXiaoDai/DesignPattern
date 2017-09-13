using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public abstract class LightState
    {
        public abstract void Handler(LightContext context);
    }
}
