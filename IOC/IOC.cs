using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public class IOC
    {
       
        public IOC()
        {
            Items = new List<IOCItemcs>();
        }

        public List<IOCItemcs> Items { get; set; }

    }
}
