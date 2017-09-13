using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class ForenoonState : WorkState
    {
        public override void Handler(WorkContext context)
        {
            if (context.Hour > 12)
            {
                Console.WriteLine("当前为下午时间");
            }
            else
            {
                context.State = new MorningState();
                context.Request();
            }
        }
    }
}
