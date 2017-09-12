using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeModel
{
    public class Person : ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public object Clone()
        {
           return this.MemberwiseClone();
        }
        public void show()
        {
            Console.WriteLine($"我的名字叫:{Name},今年{Age}岁！");
        }
    }
}
