using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
   public class Student:Person
    {
        public override string WantSleep()
        {
            return "6个小时!";
        }
        public override string WantEat()
        {
            return "吃大米!";
        }
        public override string GetName()
        {
            return "张腾";
        }
        public override string WantDink()
        {
            return "芒果汁";
        }
    }
}
