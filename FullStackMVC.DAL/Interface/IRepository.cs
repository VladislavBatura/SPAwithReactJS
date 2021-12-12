using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackMVC.DAL.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();
        void Remove(T entity);
        void Add(T entity);
        void Update(T entity);
        Task<int> SaveChangeAsync();
    }
}
