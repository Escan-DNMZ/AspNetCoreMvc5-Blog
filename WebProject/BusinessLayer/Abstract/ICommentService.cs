using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void AddCategory(Comment comment);
        //void DeleteCategory(Comment category);
        //void UpdateCategory(Comment category);
        List<Comment> GetList(int id);
        //Comment GetById(int id);
    }
}
