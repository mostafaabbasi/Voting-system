using Vote.Base;

namespace Vote.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        TEntity Create(TEntity entity);
        bool Delete(Guid id);
        TEntity GetById(Guid id);
        List<TEntity> GetAll();
    }
}
