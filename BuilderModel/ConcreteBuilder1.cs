using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderModel
{
    public class ConcreteBuilder1 : Builder
    {
        private product pro=new product();
        public override void BuilderPartA()
        {
            pro.Add("产品部件A");
        }

        public override void BuilderPartB()
        {
            pro.Add("产品部件B");
        }

        public override product GetResult()
        {
            return pro;
        }
    }
}
