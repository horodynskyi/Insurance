using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Seeds
{
    public class ReasonSeeds:IEntityTypeConfiguration<Reason>
    {
        public void Configure(EntityTypeBuilder<Reason> builder)
        {
            builder.HasData(
                new Reason
                {
                    Id = 1,
                    Name = "Died",
                    Paid = 0.75f
                },
                new Reason
                {
                    Id = 2,
                    Name = "Insurance time expired",
                    Paid = 0.75f
                });
        }
    }
}