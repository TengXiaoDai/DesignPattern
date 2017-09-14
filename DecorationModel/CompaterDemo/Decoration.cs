using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorationModel.CompaterDemo
{
    public abstract class Decoration:Compater
    {
        protected Compater compater { get; set; }
        public Decoration(Compater compater)
        {
            this.compater = compater;
        }

        public override void Print()
        {
            if (compater != null)
            {
                compater.Print();
            }
        }
    }
}
