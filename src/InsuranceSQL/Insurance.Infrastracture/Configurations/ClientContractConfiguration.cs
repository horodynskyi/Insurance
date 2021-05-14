using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Configurations
{
    public class ClientContractConfiguration:IEntityTypeConfiguration<ClientContract>
    {
        public void Configure(EntityTypeBuilder<ClientContract> builder)
        {
            builder
                .HasKey(cc => cc.Id);
            builder
                .HasOne(cc => cc.Contract).WithMany();
        }
    }
}