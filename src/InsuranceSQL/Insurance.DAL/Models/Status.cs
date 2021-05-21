using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Status:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Reason Reason { get; set; }
    }
}