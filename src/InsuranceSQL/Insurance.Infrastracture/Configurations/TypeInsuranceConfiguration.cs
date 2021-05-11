using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class TypeInsuranceConfiguration:IEntityTypeConfiguration<TypeInsurance>
    {
        public void Configure(EntityTypeBuilder<TypeInsurance> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}