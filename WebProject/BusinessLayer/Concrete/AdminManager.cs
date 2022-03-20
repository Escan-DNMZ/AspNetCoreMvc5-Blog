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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public Admin GetById(int id, params Expression<Func<Admin, object>>[] includeProperty)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> GetCategoryAll(Expression<Func<Admin, bool>> filter = null, params Expression<Func<Admin, object>>[] includeProperty)
        {
            IQueryable<Admin> query = _adminDal.Query();
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

        public List<Admin> GetList()
        {
            return _adminDal.GetAll();
        }

        public List<Admin> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Admin t)
        {
            _adminDal.Insert(t);
        }

        public void TDelete(Admin t)
        {
            _adminDal.Delete(t);
        }

        public void TUpdate(Admin t)
        {
            _adminDal.Update(t);
        }
    }
}
