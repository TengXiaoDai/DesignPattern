using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationModel.CompaterDemo
{
    public class Assessories : Decoration
    {
        public Assessories(Compater compater) : base(compater)
        {
        }
        public override void Print()
        {
            //指挥者调用上一次的功能
            base.Print();
            MyMethod();
        }
        public void MyMethod()
        {
            Console.WriteLine("添加的新功能!");
        }
    }
}
