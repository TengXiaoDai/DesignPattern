using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel.Demo
{
    public class Monthing : DayState
    {
        public override void Handler(DayContext context)
        {
            if (context.Hour > 6 & context.Hour < 9)
            {
                Console.WriteLine("起床了!");
            }
            else if (context.Hour > 10&context.Hour<12)
            {
                Console.WriteLine("上班了");
            }
            else
            {
                try
                {
                    throw new Exception("不在状态时间!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
        }
    }
}
