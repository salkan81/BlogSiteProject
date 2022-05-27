using System.Collections.Generic;

namespace DAL.Repository.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);

    }
}
