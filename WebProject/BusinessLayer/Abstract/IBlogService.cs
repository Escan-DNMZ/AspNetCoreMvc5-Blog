using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        public List<Blog> GetBlogListByWriter(int id, params Expression<Func<Blog, object>>[] includeProperty);

    }
}
