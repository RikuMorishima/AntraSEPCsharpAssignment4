using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3
{
    public class GenericRepository<T> : IRepository<T> where T : IEntity
    {
        List<T> _list;

        public GenericRepository()
        {
            _list = new List<T>();
        }
        public void Add(T item)
        {
            foreach(T item2 in _list)
            {
                if (item2.Id == item.Id)
                {
                    return; // will not update
                }
            }
            _list.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _list; 
        }

        public T GetById(int id)
        {
            foreach (T item in _list)
            {
                if (id == item.Id)
                {
                    return item; // will not update
                }
            }
            throw new Exception(); // not found
        }

        public void Remove(T item)
        {
            _list.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
