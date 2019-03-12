using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corporate2.Data.inetfaces
{
    public interface IInterface<T> where T: class
    {
      // for find all data from database
        IEnumerable<T> GetAll();
//      for checking a particular value
        IEnumerable<T> Find(Func<T, bool> predicate);
        // for check a particular id
        T GetByID(int id);
        // for create some value
        void create(T entity);

        void update(T entity);

        void delete(T entity);

        int Count(Func<T, bool> predicate);
    }
}
