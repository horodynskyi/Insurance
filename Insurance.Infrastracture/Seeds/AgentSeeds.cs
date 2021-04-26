using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Seeds
{
    public class AgentSeeds:IEntityTypeConfiguration<Agent>
    {
        
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(
                new Agent
                {
                    Id = 1,
                    FirstName = "Maksym",
                    SecondName = "Horodynksyi",
                    Patronumic = "Victorovich",
                    Salary = 10000
                },
                new Agent
                {
                    Id = 2,
                    FirstName = "Eugen",
                    SecondName = "Pronin",
                    Patronumic = "Ihorovich",
                    Salary = 100000
                });
        }
    }
}