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
        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();

        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
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

        Blog IBlogService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListByCount(int id, int count)
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
                foreach (var item in includeProperty)
                {
                    query = query.Include(item);
                }
            }

            return query.ToList();
        }
    }
}
