using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationModel
{
    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("这里是原始模板手机功能!");
        }
    }
}
