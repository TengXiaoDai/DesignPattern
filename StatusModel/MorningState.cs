using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class MorningState : WorkState
    {
        public override void Handler(WorkContext context)
        {
            if (context.Hour <= 12)
            {
                Console.WriteLine("当前为早上时间！");
            }
            else
            {
                context.State = new ForenoonState();
                context.Request();
            }
        }
    }
}
