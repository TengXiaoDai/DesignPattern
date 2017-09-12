using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderModel
{
    //起到了指挥的作用,这样用户就不用知道具体的实现流程
    public class PersonDirector
    {
        PersonBuilder per;
        public PersonDirector(PersonBuilder per)
        {
            //传如需要建造的对象
            this.per = per;
        }
        public void Complete()
        {
            per.BuildHead();
            per.BuildBody();
            per.BuildArmLeft();
            per.BuildArmRight();
            per.BuildLegLeft();
            per.BulldLegRight();
            Console.WriteLine("产品完成生产！");
        }
    }
}
