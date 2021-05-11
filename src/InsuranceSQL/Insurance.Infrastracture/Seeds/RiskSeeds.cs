using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Seeds
{
    public class RiskSeeds:IEntityTypeConfiguration<Risk>
    {
        public void Configure(EntityTypeBuilder<Risk> builder)
        {
            builder.HasData(
                new Risk
                {
                    Id = 1,
                    Sum = 300
                },
                new Risk
                {
                    Id = 2,
                    Sum = 800
                });
        }
    }
}