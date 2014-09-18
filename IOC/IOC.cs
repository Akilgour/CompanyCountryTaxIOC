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


        public T GetSingleByClassName<T>(string className)
        {
            var types = GetSingleByClassName(typeof(T), className);
            return (T)Activator.CreateInstance(types); 
        }

        public T GetSingleByClassName<T>()
        {
            var className = Items.Where(x => x.Interface.Name == typeof(T).Name).Single().ClassName;

            var types = GetSingleByClassName(typeof(T), className);
            return (T)Activator.CreateInstance(types);
        }

        private Type GetSingleByClassName(Type type, string aaa)
        {

            var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p) && p.IsClass && p.IsPublic && !p.IsGenericType && p.Name == aaa);
            return types.First();
        }

    }
}
