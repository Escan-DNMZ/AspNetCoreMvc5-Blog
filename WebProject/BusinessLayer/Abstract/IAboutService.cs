using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService:IGenericService<About>
    {
        List<T> GetCategoryAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty);
    }
}
