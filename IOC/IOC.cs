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


        public void Register<T>(string ClassName)
        {
            var item = new IOCItem(typeof(T), ClassName);
            Items.Add(item);
        }


        public IEnumerable<T> GetList<T>(string aaa)
        {
            var types = GetAllClassesOfType(typeof(T), aaa);
            return from item in types
                   select (T)Activator.CreateInstance(item);
        }

        private List<Type> GetAllClassesOfType(Type type, string aaa)
        {

            var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p) && p.IsClass && p.IsPublic && !p.IsGenericType && p.Name == aaa).ToList();
            return types;
        }

    }
}
