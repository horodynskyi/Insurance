using Company.DAL.SQLEntities.Interfaces;

namespace Company.DAL.SQLEntities
{
    public class SqlBranch:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}