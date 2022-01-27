using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager :  ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void TDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetAll(null);
        }

        public void TUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public List<Category> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id, params Expression<Func<Category, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategoryAll(Expression<Func<Category, bool>> filter = null, params Expression<Func<Category, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }
    }
}
