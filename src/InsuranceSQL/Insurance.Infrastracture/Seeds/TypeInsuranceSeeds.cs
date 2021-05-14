using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Seeds
{
    public class TypeInsuranceSeeds:IEntityTypeConfiguration<TypeInsurance>
    {
        public void Configure(EntityTypeBuilder<TypeInsurance> builder)
        {
            builder.HasData(
                new TypeInsurance
                {
                    Id = 1,
                    Name = "House",
                    Interest = 0.3
                },
                new TypeInsurance
                {
                    Id = 2,
                    Name = "Life",
                    Interest = 0.1
                });
        }
    }
}