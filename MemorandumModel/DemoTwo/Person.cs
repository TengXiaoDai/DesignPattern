using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemorandumModel.DemoTwo
{
    public class Person
    {
        public string 后悔药 { get; set; }
        public void Show()
        {
            Console.WriteLine($"您当前正在步入{后悔药}");
        }
        public 刻录数据 刻录时光机器()
        {
            return new 刻录数据(后悔药);
        }
        public void 回到从前(刻录数据 回到从前的药)
        {
            this.后悔药 = 回到从前的药.后悔药;
        }
    }
}
