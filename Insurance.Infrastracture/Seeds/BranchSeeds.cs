using Insurance.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Insurance.Infrastracture.Seeds
{
    public class BranchSeeds : IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasData(
                new Branch
                {
                    Id = 1,
                    Name = "Insurance of Dangeon Master",
                    Address = "st. Holovna 27",
                    PhoneNumber = "+380505553535"
                },
                new Branch
                {
                    Id = 2,
                    Name = "Best Insurance ",
                    Address = "st. Haharina 75",
                    PhoneNumber = "+380957456258"
                });
        }
    }
}