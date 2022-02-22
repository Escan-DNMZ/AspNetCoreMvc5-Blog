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
            return _categoryDal.GetAll();
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
            IQueryable<Category> query = _categoryDal.Query();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperty.Any())
            {
                foreach (var item in includeProperty) // 0, 1, 2 , 3
                {
                    query = query.Include(item);
                }
            }

            return query.ToList();
        }
    }
}
