using PrototypeModel.Demo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //原型模式(浅复制)
            //ConcretePrototype p1 = new ConcretePrototype("001");
            //ConcretePrototype p2 = (ConcretePrototype)p1.Clone();
            //Console.WriteLine(p2.Id);

            //原型模式(深复制)
            //ProtoType proOne = new ProtoType("2003");
            //ProtoType proTwo= proOne.Clone() as ProtoType;
            //proOne.Person.show();
            //proTwo.Person.show();
            //Console.WriteLine(proOne.Id);
            //Console.WriteLine(proTwo.Id);

            //原型模式:主要针对于复制对象,减少每一次都实例化,同时也增强了性能,复制的关键需要继承Icloneable
            //同时实现接口的克隆方法,再在里面实现this.MemberwiseClone()方法。

            //我们查看MSDN会发现，MenberwiseClone()方法是浅复制:也就是说他只能复制该方法中值类型数据,而引用类型不会被复制下来
            //那我们如何来实现深复制呢？我们需要在复制的该类型里面的引用类型加入被克隆标签。在该类型复制的时候我们将他给复制完成。
            //这样我们就完成了深复制。
            CopyFather copyOne = new CopyFather("张腾",19);
            copyOne.Show();
            CopyFather copyTwo = new CopyFather("张三", 20);
            copyTwo.Show();
            CopyFather copyContext= copyOne.Clone() as CopyFather;
            copyContext.Show();
        }
    }
}
