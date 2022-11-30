using StudentLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLib
{
    public class EntityFrameworkRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        public void Create(T obj)
        {
            context.Set<T>().Add(obj);
        }
        public IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }
        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Delete(T obj)
        {
            context.Set<T>().Remove(obj);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
