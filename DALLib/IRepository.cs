using StudentLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLib
{
    public interface IRepository<T> where T : class
    {
        void Create(T obj);
        IEnumerable<T> GetAll();
        T Get(int id);
        void Delete(T obj);
        void Save();
    }
}
