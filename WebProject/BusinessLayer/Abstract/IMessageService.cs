using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        public List<Message> GetInboxListByWriter(string p);
        List<T> GetCategoryAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty);
    }
}
