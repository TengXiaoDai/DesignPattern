using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeModel.Demo
{
    public class CopyFather:ICloneable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public CopyFather(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Show()
        {
            Console.WriteLine($"我叫{Name}今年{Age}岁了!");
        }
    }
}
