using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class ConcreteState : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteState();
        }
    }
}
