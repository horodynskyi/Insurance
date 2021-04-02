using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Branch:IEntity<int>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set;}
        public string phoneNumber { get; set;}
    }
}