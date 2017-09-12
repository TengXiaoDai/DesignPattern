using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BuilderModel
{
    public abstract class PersonBuilder
    {
        protected string g;
        protected int p;
        public PersonBuilder(string g,int p)
        {
            this.p = p;
            this.g = g;
        }
        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BulldLegRight();
    }
}
