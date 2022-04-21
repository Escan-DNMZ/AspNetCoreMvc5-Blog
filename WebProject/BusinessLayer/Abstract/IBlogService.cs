using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        public List<Blog> GetBlogListByWriterCount(int id, int count, params Expression<Func<Blog, object>>[] includeProperty);
        public List<Blog> GetBlogListByWriter(int id, params Expression<Func<Blog, object>>[] includeProperty);
        List<T> GetCategoryAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty);

    }
}
