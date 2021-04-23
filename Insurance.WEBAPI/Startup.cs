using Insurance.BLL.Interfaces;
using Insurance.BLL.Services;
using Insurance.DTO.Mapper;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces.IRepositories;
using Insurance.Repositories.Repositories.Repositories;
using Insurance.Repositories.UnitOfWork;
using Insurance.Repositories.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AutoMapper;

namespace Insurance.WEBAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region InsuranceContext
            services.AddDbContext<InsuranceDbContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("EFConnection"),
                b => b.MigrationsAssembly("Insurance.WEBAPI")));
            #endregion
            
            #region Authentication
            services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication("Bearer", options =>
                {
                    options.ApiName = "myApi";
                    options.Authority = "https://localhost:44303";
                });
            #endregion

            #region Services

            services.AddTransient<IRiskService, RiskService>();
            services.AddTransient<IContractService, ContractService>();
            services.AddTransient<IAgentService, AgentService>();

            #endregion

            #region Repositories

            services.AddTransient<IRiskRepository, RiskRepository>();
            services.AddTransient<IAgentRepository, AgentRepository>();
            services.AddTransient<IBranchRepository, BranchRepository>();
            services.AddTransient<IBranchAgentRepository, BranchAgentRepository>();
            services.AddTransient<ITariffRepository, TariffRepository>();
            services.AddTransient<ITerminatedContractRepository, TerminatedContractRepository>();
            services.AddTransient<IContractRepository, ContractRepository>();
            services.AddTransient<IReasonRepository, ReasonRepository>();
            services.AddTransient<ITypeInsuranceRepository, TypeInsuranceRepository>();

            #endregion

            #region AutoMapper
            services.AddAutoMapper(typeof(AutoMapping));
            #endregion
            
            #region UnitOfWork
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Controllers

            services.AddControllers();

            #endregion

            #region Swagger

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "Insurance.WEBAPI", Version = "v1"});
            });

            #endregion
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Insurance.WEBAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}