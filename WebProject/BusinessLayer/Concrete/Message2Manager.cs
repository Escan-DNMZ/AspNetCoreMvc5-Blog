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
    public class Message2Manager : IMessage2Service
    {
        IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }

        public Message2 GetById(int id, params Expression<Func<Message2, object>>[] includeProperty)
        {
            return _message2Dal.GetById(id);
        }

        public List<Message2> GetCategoryAll(Expression<Func<Message2, bool>> filter = null, params Expression<Func<Message2, object>>[] includeProperty)
        {
            IQueryable<Message2> query = _message2Dal.Query();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            else if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item);
                }
            }
            return query.ToList();
        }

        public List<Message2> GetInboxListByWriter(int id)
        {

            return _message2Dal.GetAll(x=>x.ReceiverId == id,x=>x.SenderUser);
        }

        public List<Message2> GetList()
        {
            return _message2Dal.GetAll();
        }

        public List<Message2> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
