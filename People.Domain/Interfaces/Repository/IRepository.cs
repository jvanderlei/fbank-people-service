using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Domain.Interfaces.Repository
{
    public interface IRepository<T, I>
    {
        IEnumerable<T> GetAll();
        T Get(I id);
        T Create(T entity);
        T Update(T entity);
        T Delete(I id);
    }
}
