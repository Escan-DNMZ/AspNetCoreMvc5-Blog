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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void TAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        

        public List<Writer> GetList()
        {
           return _writerDal.GetAll(null);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id, params Expression<Func<Writer, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetCategoryAll(Expression<Func<Writer, bool>> filter = null, params Expression<Func<Writer, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }
    }
}
