#nullable enable
namespace Insurance.DTO.DTO
{
    public class AgentDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string? Patronumic { get; set; }
        public double Salary { get; set; }
    }
}