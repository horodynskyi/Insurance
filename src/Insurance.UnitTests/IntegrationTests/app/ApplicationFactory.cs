using System;
using System.Collections.Generic;
using System.Linq;
using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Insurance.UnitTests.IntegrationTests.app
{
    public class CommonApplicationFactory<TStartup>
        : WebApplicationFactory<TStartup> where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType ==
                         typeof(DbContextOptions<InsuranceDbContext>));

                services.Remove(descriptor);

                services.AddDbContext<InsuranceDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryTestingDb");
                });

                var sp = services.BuildServiceProvider();

                using (var scope = sp.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<InsuranceDbContext>();

                    db.Database.EnsureCreated();
                    try
                    {
                        
                        db.Branches.Add(
                            new Branch
                            {
                                Address = "MAin str.",
                                Name = "Best of the best",
                                PhoneNumber = "+38055555555"
                            });
                        db.Agents.Add(new Agent
                        {
                            FirstName = "Makson",
                            SecondName = "Genius",
                            Salary = 0,
                            Branch = new Branch {Id = 1}
                        });
                        db.Reasons.Add(new Reason
                        {
                            Id = 1,
                            Paid = 0.50f
                        });
                        db.Risks.Add(new Risk()
                        {
                            Id = 1,
                            Sum = 300
                        });
                        db.Tariffs.Add(new Tariff
                        {
                            Id = 1,
                            WageRate = 20
                        });
                        db.TypeInsurances.Add(new TypeInsurance
                        {
                            Id = 1,
                            Interest = 0.2,

                        });
                        db.Statuses.Add(new Status
                        {
                            Id = 1,
                            Name = "procces",
                            Reason = new Reason
                            {
                                Id = 1
                            }
                        });
                        
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            });
        }
    }
}