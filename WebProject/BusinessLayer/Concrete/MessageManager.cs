using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetById(int id, params Expression<Func<Message, object>>[] includeProperty)
        {
            IQueryable<Message> query = _messageDal.Query();
            if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item);
                }
            }
            return query.FirstOrDefault(x=>x.MessageId == id);
        }

        public List<Message> GetCategoryAll(Expression<Func<Message, bool>> filter = null, params Expression<Func<Message, object>>[] includeProperty)
        {
            IQueryable<Message> query = _messageDal.Query();

            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item);
                }
                    
            }
            return query.ToList();
        }

        public List<Message> GetList()
        {
            return _messageDal.GetAll();
        }

        public List<Message> GetListByCount(int id, int count)
        {
            return _messageDal.GetAll(x=>x.MessageId == id).TakeLast(count).ToList();
        }

        public List<Message> GetInboxListByWriter(string p)
        {
            return _messageDal.GetAll(x=>x.Receiver == p);
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
