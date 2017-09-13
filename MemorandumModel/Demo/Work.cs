using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumModel.Demo
{
    public class Work
    {
        public string  State { get; set; }
        public Memenber SetNew()
        {
            return new Memenber(State);
        }
        public void Show()
        {
            Console.WriteLine($"当前状态{State}");
        }
        public void SetOld(Memenber memenber)
        {
            this.State = memenber.State;
        }
    }
}
