using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IRepository<T> : IDisposable
    {
        T Create(T item);
        void Delete(T item);
        void Delete(int id);
        T Get(int id);
        IQueryable<T> GetAll();
        void Save();
        T Update(T item);
    }
}
