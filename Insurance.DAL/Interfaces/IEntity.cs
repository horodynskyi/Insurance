namespace Insurance.DAL.Interfaces
{
    public interface IEntity<T>
    {
        T id { get; set;}
    }
}