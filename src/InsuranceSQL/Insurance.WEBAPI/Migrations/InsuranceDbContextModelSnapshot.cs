﻿// <auto-generated />
using System;
using Insurance.Infrastracture.Infrastracture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Insurance.WEBAPI.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    partial class InsuranceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "6.0.0-preview.2.21154.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Insurance.DAL.Models.Agent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("float")
                        .HasComputedColumnSql("([dbo].[computeSalary]([Id]))", false);

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "st. Holovna 27",
                            Name = "Insurance of Dangeon Master",
                            PhoneNumber = "+380505553535"
                        },
                        new
                        {
                            Id = 2,
                            Address = "st. Haharina 75",
                            Name = "Best Insurance ",
                            PhoneNumber = "+380957456258"
                        });
                });

            modelBuilder.Entity("Insurance.DAL.Models.ClientContract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int?>("ContractId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("ClientContracts");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RiskId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("TariffId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeInsuranceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("RiskId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TariffId");

                    b.HasIndex("TypeInsuranceId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Reason", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Paid")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Reasons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Died",
                            Paid = 0.75f
                        },
                        new
                        {
                            Id = 2,
                            Name = "Insurance time expired",
                            Paid = 0.75f
                        });
                });

            modelBuilder.Entity("Insurance.DAL.Models.Risk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Risks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Sum = 300m
                        },
                        new
                        {
                            Id = 2,
                            Sum = 800m
                        });
                });

            modelBuilder.Entity("Insurance.DAL.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReasonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReasonId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Tariff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("WageRate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Tariffs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            WageRate = 30m
                        },
                        new
                        {
                            Id = 2,
                            WageRate = 50m
                        });
                });

            modelBuilder.Entity("Insurance.DAL.Models.TypeInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Interest")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeInsurances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Interest = 0.29999999999999999,
                            Name = "House"
                        },
                        new
                        {
                            Id = 2,
                            Interest = 0.10000000000000001,
                            Name = "Life"
                        });
                });

            modelBuilder.Entity("Insurance.DAL.Models.Agent", b =>
                {
                    b.HasOne("Insurance.DAL.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Insurance.DAL.Models.ClientContract", b =>
                {
                    b.HasOne("Insurance.DAL.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId");

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Contract", b =>
                {
                    b.HasOne("Insurance.DAL.Models.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("Insurance.DAL.Models.Risk", "Risk")
                        .WithMany()
                        .HasForeignKey("RiskId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("Insurance.DAL.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Insurance.DAL.Models.Tariff", "Tariff")
                        .WithMany()
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.HasOne("Insurance.DAL.Models.TypeInsurance", "TypeInsurance")
                        .WithMany()
                        .HasForeignKey("TypeInsuranceId")
                        .OnDelete(DeleteBehavior.ClientCascade);

                    b.Navigation("Agent");

                    b.Navigation("Risk");

                    b.Navigation("Status");

                    b.Navigation("Tariff");

                    b.Navigation("TypeInsurance");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Status", b =>
                {
                    b.HasOne("Insurance.DAL.Models.Reason", "Reason")
                        .WithMany()
                        .HasForeignKey("ReasonId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Reason");
                });
#pragma warning restore 612, 618
        }
    }
}
