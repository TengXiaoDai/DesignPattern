using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
   public class QuestionFathor
    {
        public void QuestionOne()
        {
            Console.WriteLine("面向对象的几个特性？[]a:封装 b:继承 c:多态 d:抽象");
            Console.WriteLine($"答案{AnswerOne()}");
        }
        public void QuestionTwo()
        {
            Console.WriteLine("String str=new String('3423')实例化了几次?[]a:1次 b:2次 c:3次 d:4次");
            Console.WriteLine($"答案{AnswerTwo()}");
        }
        public virtual string AnswerOne()
        {
            return "";
        }
        public virtual string AnswerTwo()
        {
            return "";
        }
    }
}
