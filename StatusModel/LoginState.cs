using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public abstract class LoginState
    {
        public abstract void Handler(LoginContext context);
    }
}
