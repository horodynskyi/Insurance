using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Reason:IEntity<int>
    {
        public int id { get; set; }
        public string name { get; set; }
        public float paid { get; set; }
    }
}