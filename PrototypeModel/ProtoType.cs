using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeModel
{
    public abstract class ProtoType
    {
        public string Id { get; }
        public ProtoType(string id)
        {
            this.Id = id;
        }
        public abstract ProtoType Clone();
    }
}
