using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
   public abstract class Person
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"我叫{Name},我最想吃{WantEat()}");
        }
        public void Drink()
        {
            Console.WriteLine($"我叫{Name},我最想喝{WantDink()}");
        }
        public void Sleep()
        {
            Console.WriteLine($"我叫{Name},我想睡睡觉{WantSleep()}");
        }
        public Person()
        {
            this.Name = GetName();
        }

        public virtual string GetName()
        {
            return "";
        }
        public virtual string WantEat()
        {
            return "";
        }
        public virtual string WantDink()
        {
            return "";
        }
        public virtual string WantSleep()
        {
            return "";
        }
    }
}
