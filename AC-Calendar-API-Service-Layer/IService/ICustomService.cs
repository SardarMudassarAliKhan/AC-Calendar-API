using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC_Calendar_API_Service_Layer.IService
{
    public interface ICustomService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(long Id);
        T Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
    }
}
