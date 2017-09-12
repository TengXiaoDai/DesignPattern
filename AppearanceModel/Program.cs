using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppearanceModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //外观模式:遵循了依赖倒置原则
            //为子系统中的一组接口提供一个一致的界面,此模式定义了一个高层接口,这个接口
            //使得这一子系统更加容易使用。
            Facade face = new Facade();
            face.MethodA();
            face.MethodB();
        }
    }
}
