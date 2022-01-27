using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;  

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void TAdd(Blog blog)
        {
            _blogDal.Insert(blog);

        }

        public void TDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }
        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAll(x => x.BlogId == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAll(null).ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListByCount(int id, int count)
        {
            return _blogDal.GetAll(x => x.WriterId == id || id == 0).TakeLast(count).ToList();
        }

        public List<Blog> GetCategoryAll(Expression<Func<Blog, bool>> filter = null, params Expression<Func<Blog, object>>[] includeProperty)
        {
            IQueryable<Blog> query = _blogDal.Query();

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

        public Blog GetById(int id, params Expression<Func<Blog, object>>[] includeProperty)
        {
            IQueryable<Blog> query = _blogDal.Query();

            if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item);
                }
            }

            return query.FirstOrDefault(x=>x.BlogId == id);
        }


        public List<Blog> GetBlogListByWriter(int id, params Expression<Func<Blog, object>>[] includeProperty)
        {
           
            return _blogDal.GetAll(x => x.WriterId == id,x=>x.Category);
        }

        
    }
}
