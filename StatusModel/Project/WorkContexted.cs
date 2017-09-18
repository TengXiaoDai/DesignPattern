using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel.Project
{
    public class WorkContexted
    {
        public int Hour { get; set; }
        public WorkStates State { get; set; }
        public WorkContexted(WorkStates state)
        {
            this.State = state;
        }
        public void SetValue(int hour)
        {
            this.Hour = hour;
        }
        public void Request()
        {
            State.Show(this);
        }
    }
}
