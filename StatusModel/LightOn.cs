using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class LightOn : LightState
    {
        public override void Handler(LightContext context)
        {
            context.State = new LightOff();
        }
    }
}
