
using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Branch:IEntity<int>
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set;}
        public string PhoneNumber { get; set;}
    }
}