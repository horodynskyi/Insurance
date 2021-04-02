using Microsoft.EntityFrameworkCore;

namespace Insurance.DAL.Models
{
    [Keyless]
    public class BranchAgent
    {
        
        public Agent agent { get; set; }
        public Branch branch { get; set; }
    }
}