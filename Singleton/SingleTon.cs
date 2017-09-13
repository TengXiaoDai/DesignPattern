using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //静态初始化
    //这里我们用到了Sealed:密封类,就禁止了它派生出更多的类
    public sealed class SingleTon
    {
        public static readonly SingleTon single = new SingleTon();
        private SingleTon() { }
        public static SingleTon GetObj()
        {
            return single;
        } 
    }
}
