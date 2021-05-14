using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class ClientContract:IEntity<int>
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Contract Contract { get; set;}
    }
}