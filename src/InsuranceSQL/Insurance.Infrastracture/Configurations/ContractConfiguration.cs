using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class ContractConfiguration:IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Risk).WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);
            builder.HasOne(x => x.Tariff).WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);
            builder.HasOne(x => x.TypeInsurance).WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);
            builder.HasOne(x => x.Agent).WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);
            builder.HasOne(x => x.Status).WithMany()
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}