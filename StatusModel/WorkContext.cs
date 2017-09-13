using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
   public class WorkContext
    {
        public int Hour { get; set; }
        public WorkState State { get; set; }
        public WorkContext(WorkState state)
        {
            this.State = state;
            this.Hour = 0;
        }
        public void Request()
        {

        }
    }
}
