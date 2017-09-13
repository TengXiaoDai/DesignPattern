using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class SuccessState : LoginState
    {
        public override void Handler(LoginContext context)
        {
            if (context.UserName == "1234")
            {
                Console.WriteLine("成功");
            }
            else
            {
                context.State = new FailState();
                context.Request();
            }
        }
    }
}
