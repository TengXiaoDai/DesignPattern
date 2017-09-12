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
            //PersonThinBuilder thin = new PersonThinBuilder("张腾", 1);
            //PersonDirector director = new PersonDirector(thin);
            //director.Complete();
            //在我的理解是在建造一个东西的时候,他具体的流程不会发生改变,但是流程内部会发生改变。
            //就比方说人会经历的婴儿 幼年 青年 中年 老年,在每个人活到70岁的时候都会经历这几个阶段
            //而这几个阶段每个人的生活又是各种各样的,也就是他所经历的不同，则在他这几个阶段的方法实现也是不同的。
            //而建造的流程过程用户是不需要知道,他只需要拿到结果.

            //指挥者:通过指挥者来隔离生产流程出产品的具体流程
            Director director = new Director();
            //具体的产品
            Builder BuilderA = new ConcreteBuilder1();
            //通过指挥者来实现产品生产的流程
            director.Construct(BuilderA);
            //给结果流程就可以不用在指挥者中实现。建造者只需要得到结果就可以
            product pro=BuilderA.GetResult();
            pro.Show();
        }
    }
}
