using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Person
    {
        public void Eat()
        {
            Console.WriteLine("吃!");
        }
        public void Drink()
        {
            Console.WriteLine("喝!");
        }
        public void Sellp()
        {
            Console.WriteLine("谁!");
        }
    }
}
