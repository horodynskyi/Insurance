using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class TerminatedContractConfiguration:IEntityTypeConfiguration<TerminatedContract>
    {
        public void Configure(EntityTypeBuilder<TerminatedContract> builder)
        {
            builder.HasKey(t =>t.Id);
            builder.HasOne(x => x.Contract).WithMany();
            builder.HasOne(x => x.Reason).WithMany();
        }
    }
}