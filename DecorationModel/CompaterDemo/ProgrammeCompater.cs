using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationModel.CompaterDemo
{
    //在最开始生产的时候生产出最原始的功能
    public class ProgrammeCompater : Compater
    {
        public override void Print()
        {
            Console.WriteLine("编程功能!");
        }
    }
}
