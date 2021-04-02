using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class TerminatedContract
    {
        public Contract contract { get; set; }
        public Reason reason { get; set; }
        
    }
}