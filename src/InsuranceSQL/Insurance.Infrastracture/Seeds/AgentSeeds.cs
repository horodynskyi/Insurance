using Bogus;
using Bogus.Extensions;
using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Seeds
{
    public class AgentSeeds:IEntityTypeConfiguration<Agent>
    {
        
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
           
            /*var ids = 3;
            var stockAgents = new Faker<Agent>("uk")
                .RuleFor(ag => ag.Id, f => ids++)
                .RuleFor(ag => ag.FirstName, f=>f.Name.FirstName())
                .RuleFor(ag => ag.SecondName,f=>f.Name.LastName());
            builder
                .HasData(stockAgents.GenerateBetween(10, 10));*/
        }
    }
}