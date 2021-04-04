using Insurance.BLL.Interfaces;
using Insurance.BLL.Services;
using Insurance.Infrastracture.Infrastracture;
using Insurance.Repositories.Interfaces;
using Insurance.Repositories.Interfaces.IRepositories;
using Insurance.Repositories.Repositories;
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
           
            services.AddDbContext<InsuranceDbContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("EFConnection"),
                b => b.MigrationsAssembly("Insurance.WEBAPI")));

            #region Services

            services.AddTransient<IRiskService, RiskService>();
            

            #endregion

            #region Repositories

            services.AddTransient<IRiskRepository, RiskRepository>();

            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "Insurance.WEBAPI", Version = "v1"}); });
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}