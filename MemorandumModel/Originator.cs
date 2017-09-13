using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumModel
{
    //发起人
    public class Originator
    {
        public string State { get; set; }
        public Memento CreateMemento()
        {
            return (new Memento(State));
        }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public void Show()
        {
            Console.WriteLine($"当前状态{State}");
        }
    }
}
