using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel.Demo
{
    public class DayContext
    {
        public int Hour { get; set; }
        public DayState DayState { get; set; }
        public DayContext(DayState DayState)
        {
            this.DayState = DayState;
        }
        public void Request()
        {
            DayState.Handler(this);
        }
        public void SetVal(int hour)
        {
            this.Hour = hour;
        }
    }
}
