namespace Company.DAL.SQLEntities.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}