using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //建造者模式
            PersonThinBuilder thin = new PersonThinBuilder("张腾", 1);
            PersonDirector director = new PersonDirector(thin);
            director.Complete();
            //在我的理解是在建造一个东西的时候,他具体的流程不会发生改变,但是流程内部会发生改变。
            //就比方说人会经历的婴儿 幼年 青年 中年 老年,在每个人活到70岁的时候都会经历这几个阶段
            //而这几个阶段每个人的生活又是各种各样的,也就是他所经历的不同，则在他这几个阶段的方法实现也是不同的。
        }
    }
}
