using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class TerminatedContract:IEntity<int>
    {
        public int id { get; set; }
        public Reason reason { get; set; }
    }
}