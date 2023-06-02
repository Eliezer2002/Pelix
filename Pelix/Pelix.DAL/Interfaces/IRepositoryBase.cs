
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetbyId(int id);
        void SaveChanges();
    }
}
