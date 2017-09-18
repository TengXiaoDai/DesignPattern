using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式:只允许对象只能是实例化一次,我们将他的构造函数定义为私有的时候外部就不能够实例化该对象,但是外部我们又不能直接的实例化,我们知道Privite内部是可以
            //被调用的,于是我们可以在他的内部中调用其对应的方法来创建它的对象,这样我们就可可以实现对象只被实例化一次。
            //Context contex = new Context();显然我们这里是不能编译通过的
             Context context=Context.CreateInstence();//这样我们就实现了单例模式,该对象在实例化的过程中创建出来的对象和之前的是一样的。但是这种存在着弊病
            //那就是在单线程的时候我们确实能够保证对象的唯一,但是针对于多线程我们并不能保证它是唯一的。
             
            //多线程下的单例模式(lock)
            MultiSingle.Create();

            //在C#与公共语言运行库提供了一种"静态初始化"，这种方法不需要开发人员显示的编写线程安全代码
            SingleTon sig1=SingleTon.GetObj();
        }
    }
}
