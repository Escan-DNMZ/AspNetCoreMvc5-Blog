using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Delete(T t)
        {
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }



        public void Insert(T t)
        {
            
            c.Update(t);
            c.Add(t);
            c.SaveChanges();
        }



        public void Update(T t)
        {
            using (Context context = new Context())
            {
                /*
                 Entity üzerinde değişiklik yapıldığını gösterir.
                 SaveChanges işlemiyle birlikte veritabanına da değişiklik(ler) yansıyacaktır.
                 SaveChanges sonrası entity state’i UnChanged olarak değişecektir.
                 */

                context.Entry(t).State = EntityState.Modified;
                //c.Update(t);
                context.SaveChanges();
            }

        }


        public List<T> GetAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> query = c.Set<T>();

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

        public IQueryable<T> Query()
        {
            return c.Set<T>().AsQueryable();
        }

        public T GetById(int id, params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> query = (IQueryable<T>)c.Set<T>().Find(id);

            if (includeProperty.Any())
            {
                foreach (var item in includeProperty)
                {
                    query = query.Include(item);
                }
            }

            return query.FirstOrDefault();
        }


    }
}
