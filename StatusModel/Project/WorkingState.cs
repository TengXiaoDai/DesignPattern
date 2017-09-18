using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel.Project
{
    public class WorkingState : WorkStates
    {
        public override void Show(WorkContexted context)
        {
            if (context.Hour > 10)
            {
                Console.WriteLine("上班!");
            }
            else
            {
                new WorkContexted(new WorkedState()).Request();
            }
        }
    }
}
