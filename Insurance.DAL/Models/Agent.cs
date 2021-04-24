using Insurance.DAL.Interfaces;

namespace Insurance.DAL.Models
{
    public class Agent:IEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronumic { get; set; }
        public decimal Salary { get; set; }
    }
}