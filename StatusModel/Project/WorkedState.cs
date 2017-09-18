using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel.Project
{
    public class WorkedState : WorkStates
    {
        public override void Show(WorkContexted context)
        {
            if (context.Hour < 10)
            {
                Console.WriteLine("下班!");
            }
            else
            {
                new WorkContexted(new WorkingState()).Request();
            }
        }
    }
}
