using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel.Demo
{
    public abstract class DayState
    {
        public abstract void Handler(DayContext context);
    }
}
