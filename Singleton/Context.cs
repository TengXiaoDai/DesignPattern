using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Context
    {
        private static Context context { get; set; }
        private Context()
        {

        }
        public static Context CreateInstence()
        {
            if (context==null)
            {
                context = new Context();
            }
            return context;
        }
    }
}
