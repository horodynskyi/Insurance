using System.ComponentModel.DataAnnotations;
using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Agent:IEntity<int>
    {
      
        public int id { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string patronumic { get; set; }
        public decimal salary { get; set; }
    }
}