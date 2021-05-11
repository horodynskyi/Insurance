using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Seeds
{
    public class TariffSeeds:IEntityTypeConfiguration<Tariff>
    {
        public void Configure(EntityTypeBuilder<Tariff> builder)
        {
            builder.HasData(
                new Tariff
                {
                    Id = 1,
                    WageRate = 30
                },
                new Tariff
                {
                    Id = 2,
                    WageRate = 50
                });
        }
    }
}