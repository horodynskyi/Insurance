using System;
using System.Collections.Generic;
using System.Linq;
using Insurance.DAL.Models;
using Insurance.Infrastracture.Infrastracture;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IntegrationTests.app
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
                        db.Branches.AddRange(
                            new List<Branch>()
                            {
                                new Branch()
                                {
                                    Id = 1,
                                    Address = "MAin str.",
                                    Name = "Best of the best",
                                    PhoneNumber = "+38055555555"
                                }
                            });
                        db.Agents.AddRange(new List<Agent>
                        {
                            new Agent {
                                Id = 1, 
                                FirstName = "Makson", 
                                SecondName = "Genius",
                                Branch = new Branch(){Id = 1}
                            },
                            new Agent {
                                Id = 2, 
                                FirstName = "Olexandro", 
                                SecondName = "Git master",
                                Branch = new Branch(){Id = 1}
                            }
                        });
                        db.SaveChanges();
                    }
                    catch (Exception)
                    {
                    }
                }
            });
        }
    }
}