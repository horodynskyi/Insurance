using Insurance.DAL.Models;
using Insurance.Infrastracture.Configurations;
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
        public DbSet<BranchAgent> BranchAgents { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<Risk> Risks { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        public DbSet<TerminatedContract> TerminatedContracts { get; set; }
        public DbSet<TypeInsurance> TypeInsurances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AgentConfiguration());
            modelBuilder.ApplyConfiguration(new ContractConfiguration());
            modelBuilder.ApplyConfiguration(new BranchConfiguration());
            modelBuilder.ApplyConfiguration(new TariffConfiguration());
            modelBuilder.ApplyConfiguration(new ReasonConfiguration());
            modelBuilder.ApplyConfiguration(new TypeInsuranceConfiguration());
            modelBuilder.ApplyConfiguration(new TerminatedContractConfiguration());
            modelBuilder.ApplyConfiguration(new BranchAgentConfiguration());
            modelBuilder.ApplyConfiguration(new RiskConfiguration());
        }
    }
}