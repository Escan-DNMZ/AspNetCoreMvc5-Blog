using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public NewsLatter GetById(int id, params Expression<Func<NewsLatter, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetCategoryAll(Expression<Func<NewsLatter, bool>> filter = null, params Expression<Func<NewsLatter, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetList()
        {
            throw new NotImplementedException();
        }

        public List<NewsLatter> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public void TAdd(NewsLatter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }

        public void TDelete(NewsLatter t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(NewsLatter t)
        {
            throw new NotImplementedException();
        }
    }
}
