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
    public class TopicsManager : ITopicService
    {
        ITopicDal _topicDal;

        public TopicsManager(ITopicDal topicDal)
        {
            _topicDal = topicDal;
        }
        public bool Add(Topic entity)
        {
           return _topicDal.Add(entity);
        }

        public bool Delete(Topic entity)
        {
            return _topicDal.Delete(entity);
        }

        public IEnumerable<Topic> GetAll()
        {
            return _topicDal.GetAll();
        }

        public Topic GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Topic entity)
        {
            return _topicDal.Update(entity);
        }
    }
}
