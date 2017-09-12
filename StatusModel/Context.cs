using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusModel
{
    public class Context
    {
        private State state;
        public State State
        {
            //设置可读写的的状态属性,用于读取当前状态和设置新状态
            get { return state; }
            set {
                state = value;
                Console.WriteLine($"当前状态{state.GetType().Name}");
            }
        }
        public Context(State state)
        {
            //定义Context的初始状态
            this.state = state;
        }
        public void Request()
        {
            //对请求做处理,并设置下一状态
            state.Handle(this);
        }
    }
}
