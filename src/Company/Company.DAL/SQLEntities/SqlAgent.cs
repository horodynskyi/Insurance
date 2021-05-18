using Company.DAL.SQLEntities.Interfaces;

namespace Company.DAL.SQLEntities
{
    public class SqlAgent : IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int BranchId { get; set; }
        public int salary { get; set; }
    }
}