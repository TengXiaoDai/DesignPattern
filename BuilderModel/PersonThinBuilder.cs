using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderModel
{
    public class PersonThinBuilder : PersonBuilder
    {
        public PersonThinBuilder(string g, int p) : base(g, p)
        {
        }

        public override void BuildArmLeft()
        {
            Console.WriteLine("建造步骤1");
        }

        public override void BuildArmRight()
        {
            Console.WriteLine("建造步骤2");
        }

        public override void BuildBody()
        {
            Console.WriteLine("建造步骤3");
        }

        public override void BuildHead()
        {
            Console.WriteLine("建造步骤4");
        }

        public override void BuildLegLeft()
        {
            Console.WriteLine("建造步骤5");
        }

        public override void BulldLegRight()
        {
            Console.WriteLine("建造步骤6");
        }
    }
}
