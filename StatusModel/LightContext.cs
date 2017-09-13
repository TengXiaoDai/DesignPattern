using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class LightContext
    {
        public LightState State { get; set; }
        public LightContext(LightState state)
        {
            this.State = state;
        }
        public void Request()
        {
            State.Handler(this);
        }
    }
}
