using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentDal = commentdal; 
        }

        public void TAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetAll(x => x.BlogId == id);
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListByCount(int id, int count)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id, params Expression<Func<Comment, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetCategoryAll(Expression<Func<Comment, bool>> filter = null, params Expression<Func<Comment, object>>[] includeProperty)
        {
            throw new NotImplementedException();
        }
    }
}
