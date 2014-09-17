using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControl
{
    public class IOC
    {
       
        public IOC()
        {
            Items = new List<IOCItem>();
        }

        public List<IOCItem> Items { get; set; }

   
        public void Register<T>( string ClassName )
        {
            var item = new IOCItem(typeof(T), ClassName);
            Items.Add(item);
        }
    }
}
