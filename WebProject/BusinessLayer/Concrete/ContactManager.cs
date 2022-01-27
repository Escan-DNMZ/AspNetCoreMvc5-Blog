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
    public class ContactManager:IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetAll(null);
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id, params Expression<Func<Contact, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetCategoryAll(Expression<Func<Contact, bool>> filter = null, params Expression<Func<Contact, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }
    }
}
