using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public  class MultiSingle
    {
        private static MultiSingle multiSingle;
        private static object obj = new object();
        private MultiSingle() { }
        public static MultiSingle Create()
        {
            if (multiSingle == null)
            {
                //在这里我们为什么需要锁住另外创建的对象而我们不直接锁住mutiSingle
                //因为我们知道这个实例可能根本就没有我们如何锁它.
                lock (obj)
                {
                    if (multiSingle == null)
                    {
                        multiSingle = new MultiSingle();
                    }
                }
            }
            return multiSingle;
        }
    }
}
