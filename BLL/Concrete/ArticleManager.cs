using BLL.Abstract;
using DAL.Repository.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }
        public bool Add(Article entity)
        {
            return _articleDal.Add(entity);
        }

        public bool Delete(Article entity)
        {
            return _articleDal.Delete(entity);
        }

        public IEnumerable<Article> GetAll()
        {
            return _articleDal.GetAll();
        }

        public Article GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Article entity)
        {
            return _articleDal.Update(entity);
        }
    }
}
