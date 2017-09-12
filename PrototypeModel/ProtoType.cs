using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeModel
{
    public  class ProtoType:ICloneable
    {
        public string Id { get; set; }
        //深复制
        public Person Person { get; set; }
        public ProtoType(string id)
        {
            Person = new Person("张腾",23);
            this.Id = id;
        }
        private ProtoType(Person person)
        {
            this.Person = person.Clone() as Person;
        }
        public object Clone()
        {
            //克隆之前让之前的克隆完成，然后在给这个对象相关对象复制,
            //最终返回一个深复制的简历对象。
           ProtoType pro = new ProtoType(this.Person);
           pro.Id = "001";
           return pro;
        }
    }
}
