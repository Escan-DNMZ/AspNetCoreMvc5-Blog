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
    public class NotificationManager:INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public Notification GetById(int id, params Expression<Func<Notification, object>>[] includeProperty)
        {
            return _notificationDal.GetById(id);
        }

        public List<Notification> GetCategoryAll(Expression<Func<Notification, bool>> filter = null, params Expression<Func<Notification, object>>[] includeProperty)
        {
            IQueryable<Notification> query = _notificationDal.Query();
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

        public List<Notification> GetList()
        {
            return _notificationDal.GetAll().ToList();
        }

        public List<Notification> GetListByCount(int id, int count)
        {
            return _notificationDal.GetAll(x => x.NotificationId == id).TakeLast(count).ToList();
        }

        public void TAdd(Notification t)
        {
            _notificationDal.Insert(t);
        }

        public void TDelete(Notification t)
        {
            _notificationDal.Delete(t);
        }

        public void TUpdate(Notification t)
        {
            _notificationDal.Update(t);
        }
    }
}
