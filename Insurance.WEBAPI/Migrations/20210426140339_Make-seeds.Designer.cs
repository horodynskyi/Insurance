﻿// <auto-generated />
using System;
using Insurance.Infrastracture.Infrastracture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Insurance.WEBAPI.Migrations
{
    [DbContext(typeof(InsuranceDbContext))]
    [Migration("20210426140339_Make-seeds")]
    partial class Makeseeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronumic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Maksym",
                            Patronumic = "Victorovich",
                            Salary = 10000m,
                            SecondName = "Horodynksyi"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Eugen",
                            Patronumic = "Ihorovich",
                            Salary = 100000m,
                            SecondName = "Pronin"
                        });
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

            modelBuilder.Entity("Insurance.DAL.Models.BranchAgent", b =>
                {
                    b.Property<int?>("AgentId")
                        .HasColumnType("int");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.HasIndex("AgentId");

                    b.HasIndex("BranchId");

                    b.ToTable("BranchAgents");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgentId")
                        .HasColumnType("int");

                    b.Property<int?>("BranchId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RiskId")
                        .HasColumnType("int");

                    b.Property<int?>("TariffId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeInsuranceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.HasIndex("BranchId");

                    b.HasIndex("RiskId");

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

            modelBuilder.Entity("Insurance.DAL.Models.TerminatedContract", b =>
                {
                    b.Property<int?>("ContractId")
                        .HasColumnType("int");

                    b.Property<int?>("ReasonId")
                        .HasColumnType("int");

                    b.HasIndex("ContractId")
                        .IsUnique()
                        .HasFilter("[ContractId] IS NOT NULL");

                    b.HasIndex("ReasonId");

                    b.ToTable("TerminatedContracts");
                });

            modelBuilder.Entity("Insurance.DAL.Models.TypeInsurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeInsurances");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "House"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Life"
                        });
                });

            modelBuilder.Entity("Insurance.DAL.Models.BranchAgent", b =>
                {
                    b.HasOne("Insurance.DAL.Models.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.HasOne("Insurance.DAL.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.Navigation("Agent");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("Insurance.DAL.Models.Contract", b =>
                {
                    b.HasOne("Insurance.DAL.Models.Agent", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.HasOne("Insurance.DAL.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.HasOne("Insurance.DAL.Models.Risk", "Risk")
                        .WithMany()
                        .HasForeignKey("RiskId");

                    b.HasOne("Insurance.DAL.Models.Tariff", "Tariff")
                        .WithMany()
                        .HasForeignKey("TariffId");

                    b.HasOne("Insurance.DAL.Models.TypeInsurance", "TypeInsurance")
                        .WithMany()
                        .HasForeignKey("TypeInsuranceId");

                    b.Navigation("Agent");

                    b.Navigation("Branch");

                    b.Navigation("Risk");

                    b.Navigation("Tariff");

                    b.Navigation("TypeInsurance");
                });

            modelBuilder.Entity("Insurance.DAL.Models.TerminatedContract", b =>
                {
                    b.HasOne("Insurance.DAL.Models.Contract", "Contract")
                        .WithOne()
                        .HasForeignKey("Insurance.DAL.Models.TerminatedContract", "ContractId");

                    b.HasOne("Insurance.DAL.Models.Reason", "Reason")
                        .WithMany()
                        .HasForeignKey("ReasonId");

                    b.Navigation("Contract");

                    b.Navigation("Reason");
                });
#pragma warning restore 612, 618
        }
    }
}
