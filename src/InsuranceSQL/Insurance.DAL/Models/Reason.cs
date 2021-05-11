using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Reason:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Paid { get; set; }
    }
}