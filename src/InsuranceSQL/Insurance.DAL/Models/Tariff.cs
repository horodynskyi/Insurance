using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Tariff:IEntity<int>
    {
        public int Id { get; set; }
        public decimal WageRate { get; set; }
    }
}