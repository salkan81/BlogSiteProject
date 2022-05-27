using Core.Concrete;
using DAL.Context;
using DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.Concrete
{
    public class ArticleRepositoryDal : GenericRepository<Article>, IArticleDal
    {
        private readonly ApplicationDbContext db;

        public ArticleRepositoryDal(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }
    }
}
