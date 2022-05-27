using Core.Abstract;
using Core.Concrete;
using DAL.Context;
using DAL.Repository.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repository.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly ApplicationDbContext db;

        public GenericRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public bool Add(T entity)
        {
            try
            {
                db.Set<T>().Add(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }

        }

        public bool Delete(T entity)
        {
            try
            {
                db.Set<T>().Remove(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>();
        }

        public bool Update(T entity)
        {
            try
            {
                db.Set<T>().Update(entity);
                return db.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
