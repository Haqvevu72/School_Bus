using Context.Contexts;
using Context.Repositories.Abstract;
using Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Repositories.Concrete
{
    public class Repository<T> : IBaseRepository<T> where T : BaseEntity, new()
    {
        private readonly SchoolBusDB schoolBusDB;

        private readonly DbSet<T> DB_Set;

        public Repository()
        {
            schoolBusDB = new SchoolBusDB();
            DB_Set = schoolBusDB.Set<T>();
        }

        public void Add(T entity)
        {
            DB_Set.Add(entity);
        }

        public void AddRange(List<T> entities)
        {
            DB_Set.AddRange(entities);
        }

        public void Delete(T entity)
        {
            DB_Set.Remove(entity);
        }

        public List<T> GetAll()
        {
            return DB_Set.ToList();
        }

        public void SaveChanges()
        {
            schoolBusDB.SaveChanges();
        }

        public void Update(T entity)
        {
            DB_Set.Update(entity);
        }
    }
}
