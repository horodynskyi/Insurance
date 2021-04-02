using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Tariff:IEntity<int>
    {
        public int id { get; set; }
        public decimal wageRate { get; set; }
    }
}