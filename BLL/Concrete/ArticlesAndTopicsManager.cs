using BLL.Abstract;
using Core.Concrete;
using DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class ArticlesAndTopicsManager : IArticlesAndTopicsService
    {
        IArticlesAndTopicsDal _articlesAndTopicsDal;

        public ArticlesAndTopicsManager(IArticlesAndTopicsDal articlesAndTopicsDal)
        {
            _articlesAndTopicsDal = articlesAndTopicsDal;
        }
        public bool Add(ArticlesAndTopics entity)
        {
           return _articlesAndTopicsDal.Add(entity);
        }

        public bool Delete(ArticlesAndTopics entity)
        {
           return _articlesAndTopicsDal.Delete(entity);
        }

        public IEnumerable<ArticlesAndTopics> GetAll()
        {
            return _articlesAndTopicsDal.GetAll();
        }

        public ArticlesAndTopics GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ArticlesAndTopics entity)
        {
            return _articlesAndTopicsDal.Update(entity);
        }
    }
}
