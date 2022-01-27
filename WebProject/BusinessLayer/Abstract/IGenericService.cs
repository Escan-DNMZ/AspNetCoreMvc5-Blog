using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {

        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();

        List<T> GetListByCount(int id, int count);


        T GetById(int id, params Expression<Func<T, object>>[] includeProperty);
        List<T> GetCategoryAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty);
    }
}
