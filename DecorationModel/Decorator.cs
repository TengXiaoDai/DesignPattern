using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationModel
{
    public abstract class Decorator:Phone
    {
        protected Phone phone;
        //传入的是被装饰着对象
        public void DecoratorObj(Phone phone)
        {
            this.phone = phone;
        }
        public override void Print()
        {
            if (phone!=null)
            {
                //在其使用的时候必须执行原来的模板代码
                phone.Print();
            }
        }
    }
}
