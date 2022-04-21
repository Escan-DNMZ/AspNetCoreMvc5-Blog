using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


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
           return _writerDal.GetAll();
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        public List<Writer> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id, params Expression<Func<Writer, object>>[] includeProperty)
        {
            IQueryable<Writer> query = _writerDal.Query();

            if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item);
                }
            }

            return query.FirstOrDefault(x => x.WriterId == id);
        }

        
    }
}
