using EntityLayer.Concrete;


namespace BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
       List<T> GetCategoryAll(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includeProperty);
    }
}
