using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Risk:IEntity<int>
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
    }
}