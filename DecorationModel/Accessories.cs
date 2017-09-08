using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationModel
{
    public class Accessories:Decorator
    {
        public override void Print()
        {
            //在新产品生成的时候需要保留住原始的功能同时也可以添加自己的功能
            //重这里我们发现了他准寻了开放-封闭原则,多扩展，少修改的原则。
            base.Print();
            //同时带上自己的功能
            Console.WriteLine("原始功能添加完毕!");
            Method();
            Console.WriteLine("功能装饰完毕!");
        }
        public void Method()
        {
            Console.WriteLine("正在追加我的的特有的功能！");
        }
    }
}
