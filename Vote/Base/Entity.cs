namespace Vote.Base
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; internal set; }
    }
}
