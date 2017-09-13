using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //模板方法:当我们要完成在某一细节层次一致的一个过程或者一个步骤,但其个别步骤
            //在更详细的层次上的实现可能不同时,我们通常考虑用模板方法模式来处理.
            //Console.WriteLine("学生A的试卷");
            //QuestionFathor one = new StudentOne();
            //one.QuestionOne();
            //one.QuestionTwo();
            //备注:我们既然使用了继承我们在子类中重复的代码就需要上升到父类去,
            //而不是让每一个子类都去重复。
            Person per = new Student();
            per.Drink();
            per.Eat();
            per.Sleep();
        }
    }
}
