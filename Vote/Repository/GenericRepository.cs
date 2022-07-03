using Vote.Base;

namespace Vote.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private static readonly List<TEntity> _entities;

        static GenericRepository()
        {
            _entities = new List<TEntity>();
        }

        public virtual TEntity Create(TEntity entity)
        {
            _entities.Add(entity);
            return entity;
        }

        public virtual bool Delete(Guid id)
        {
            var entity = GetById(id);

            if (entity is not null)
            {
                _entities.Remove(entity);
                return true;
            }

            return false;
        }

        public virtual List<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            return _entities.FirstOrDefault(f => f.Id.Equals(id));
        }
    }
}
