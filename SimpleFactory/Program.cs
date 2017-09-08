using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operation作为一个父类,也相当于一个接口,子类去实现他们的共同功能
            //然后通过简单工厂来生产出不同的产品。最后通过得到的产品去调用他们的行为方法
            Operation oper;
            oper=OperationFactory.CreateOperate("+");
            oper.NumberA = 3;
            oper.NumberB = 4;
           Console.WriteLine(oper.GetResult());
            //UML简介
            //1.在UML中,【+】代表着public,【-】代表着prvite,【#】代表着protend
            //2.如果A类继承了B类我们用【空心的三角形+实线】表示
            //3.如果A类实现了接口，则我们用【空心的三角形+虚线】来表示
            //4.如果我们在A类中需要"知道"另外的一个类时我们就用关联，关联的关系我们用【实线箭头】来表示
            //5.聚合关系:表示一种弱的引用关系,体现的是A对象可以包含B对象,但B对象不是A对象的一部分(大雁-雁群)，他们的生命周期不一样【空心的菱形+实线箭头来表示】
            //6.合成【组合】关系:是一种强的"拥有关系"，体现了严格的部分和整体的关系,整体和部分的生命周期一样。（鸟-翅膀）【实心的菱形+实线箭头】来表示。
        }
    }
}
