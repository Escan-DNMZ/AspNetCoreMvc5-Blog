using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {

        public List<Comment> GetCommentListByWriter(int id, params Expression<Func<Comment, object>>[] includeProperty);
       
    }
}
