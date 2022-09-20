using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Core
{
    public abstract class Repository<T> : IReposotory<T> where T : class
    {
        private readonly MyDbContext _context;
        public Repository(MyDbContext context)
        {
            _context = context;
        }
        public IQueryable<T> Query() =>
            _context.Set<T>().AsQueryable();

        public virtual async void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public virtual void Insert(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }
        public virtual async void Update(T item)
        {
            _context.Set<T>().Update(item);
            _context.SaveChanges();
        }


    }
}
