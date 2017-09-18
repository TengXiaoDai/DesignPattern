using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel.Project
{
    public abstract class WorkStates
    {
        public abstract void Show(WorkContexted context);
    }
}
