using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class StudentOne:QuestionFathor
    {
        public override string AnswerOne()
        {
            return "A";
        }
        public override string AnswerTwo()
        {
            return "B";
        }
    }
}
