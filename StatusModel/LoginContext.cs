using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class LoginContext
    {
        public LoginState State { get; set; }
        public string UserName { get; set; }
        public LoginContext(LoginState state)
        {
            this.State = state;
        }
        public void Request()
        {
            State.Handler(this);
        }
        public void SetValue(string userName)
        {
            this.UserName = userName;
        }
    }
}
