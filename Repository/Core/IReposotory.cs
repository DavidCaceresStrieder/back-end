using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Core
{
    public interface IReposotory<T>
    {
        IQueryable<T> Query();
        void Insert(T item);
        void Update(T item);   
        void Delete(T item);
    }
}
