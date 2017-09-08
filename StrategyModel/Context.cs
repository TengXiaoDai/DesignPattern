using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    //使用Context上下文用一个ConcreteStrategy来配置,维护一个对Strategy对象的引用
    public class Context
    {
        public Strategy strategy { get; set; }
        //初始化的时候传入策略对象
        //改造前:
        //public Context(Strategy strategy)
        //{
        //    this.strategy = strategy;
        //}
        //改造后,用户是需要传入参数就可以的到具体对象,调用不同的算法,
        //这样用户在前台就可以不用认识到多个类型,只需要认识一个就可以实现
        public Context(string type)
        {
            switch (type)
            {
                case "A":
                    strategy = new ConcreteStrategyA();
                    break;
                case "B":
                    strategy = new ConcreteStrategyB();
                    break;
                default:
                    break;
            }
        }
        //上下文接口
        public void ContextInterface()
        {
            //根据具体的策队对象,调用他对应的算法
            strategy.AlgoristhmInterface();
        }
    }
}
