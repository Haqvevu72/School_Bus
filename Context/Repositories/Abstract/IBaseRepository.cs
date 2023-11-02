
namespace Context.Repositories.Abstract
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        List<T> GetAll();

        void AddRange(List<T> entities);

        void SaveChanges();
    }
}
