using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class ReasonConfiguration:IEntityTypeConfiguration<Reason>
    {
        public void Configure(EntityTypeBuilder<Reason> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}