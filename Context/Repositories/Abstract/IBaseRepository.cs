
namespace Context.Repositories.Abstract
{
    public interface IBaseRepository<T>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        ICollection<T> GetAll();

        void AddRange(ICollection<T> entities);

        void SaveChanges();
    }
}
