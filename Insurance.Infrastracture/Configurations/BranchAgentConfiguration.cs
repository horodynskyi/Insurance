using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class BranchAgentConfiguration:IEntityTypeConfiguration<BranchAgent>
    {
        public void Configure(EntityTypeBuilder<BranchAgent> builder)
        {
            builder.HasNoKey();
            builder.HasOne(x => x.agent).WithMany();
            builder.HasOne(x => x.branch).WithMany();
        }
    }
}