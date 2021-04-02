using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Risk:IEntity<int>
    {
        public int id { get; set; }
        public decimal sum { get; set; }
    }
}