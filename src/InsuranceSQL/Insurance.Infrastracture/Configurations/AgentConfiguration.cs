using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Branch).WithMany();
            builder.Property(e => e.Salary)
                .HasComputedColumnSql("([dbo].[computeSalary]([Id]))",false);
            
        }
    }
}