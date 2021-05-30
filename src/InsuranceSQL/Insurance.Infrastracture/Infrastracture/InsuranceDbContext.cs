using Insurance.DAL.Models;
using Insurance.Infrastracture.Configurations;
using Insurance.Infrastracture.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Infrastracture.Infrastracture
{
    public sealed class InsuranceDbContext:DbContext
    {
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Branch> Branches { get; set; }
        
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TypeInsurance> TypeInsurances { get; set; }
        public DbSet<ClientContract> ClientContracts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Relations
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new AgentConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new TariffConfiguration());
            modelBuilder.ApplyConfiguration(new ReasonConfiguration());
            modelBuilder.ApplyConfiguration(new TypeInsuranceConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new RiskConfiguration());
            modelBuilder.ApplyConfiguration(new ClientContractConfiguration());
            #endregion
            
            #region Seeds
            modelBuilder.ApplyConfiguration(new BranchSeeds());
            modelBuilder.ApplyConfiguration(new AgentSeeds());
          
            modelBuilder.ApplyConfiguration(new ReasonSeeds());
            modelBuilder.ApplyConfiguration(new RiskSeeds());
            modelBuilder.ApplyConfiguration(new TariffSeeds());
            modelBuilder.ApplyConfiguration(new TypeInsuranceSeeds());
            #endregion
          
         
              
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}