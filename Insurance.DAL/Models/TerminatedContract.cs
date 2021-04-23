using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class TerminatedContract
    {
        public Contract Contract { get; set; }
        public Reason Reason { get; set; }
        
    }
}