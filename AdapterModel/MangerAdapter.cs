using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterModel
{
    public class MangerAdapte:MangerTarget
    {
        private MangerAdaptee adapter = new MangerAdaptee();
        public override void Handler()
        {
            adapter.Show();
        }
    }
}
