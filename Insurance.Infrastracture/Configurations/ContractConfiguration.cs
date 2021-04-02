using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class ContractConfiguration:IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.HasKey(x => x.id);
            builder.HasOne(x => x.risk).WithMany();
            builder.HasOne(x => x.tariff).WithMany();
            builder.HasOne(x => x.typeInsurance).WithMany();
            builder.HasOne(x => x.branch).WithMany();
            builder.HasOne(x => x.agent).WithMany();
        }
    }
}