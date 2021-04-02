using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.WEBAPI.Migrations
{
    public partial class AddModelAndReferences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    secondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patronumic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Reasons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paid = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reasons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Risks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sum = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tariffs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wageRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tariffs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TypeInsurances",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeInsurances", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BranchAgents",
                columns: table => new
                {
                    agentid = table.Column<int>(type: "int", nullable: true),
                    branchid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_BranchAgents_Agents_agentid",
                        column: x => x.agentid,
                        principalTable: "Agents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BranchAgents_Branches_branchid",
                        column: x => x.branchid,
                        principalTable: "Branches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    riskid = table.Column<int>(type: "int", nullable: true),
                    tariffid = table.Column<int>(type: "int", nullable: true),
                    typeInsuranceid = table.Column<int>(type: "int", nullable: true),
                    branchid = table.Column<int>(type: "int", nullable: true),
                    agentid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contracts_Agents_agentid",
                        column: x => x.agentid,
                        principalTable: "Agents",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Branches_branchid",
                        column: x => x.branchid,
                        principalTable: "Branches",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Risks_riskid",
                        column: x => x.riskid,
                        principalTable: "Risks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Tariffs_tariffid",
                        column: x => x.tariffid,
                        principalTable: "Tariffs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_TypeInsurances_typeInsuranceid",
                        column: x => x.typeInsuranceid,
                        principalTable: "TypeInsurances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TerminatedContracts",
                columns: table => new
                {
                    contractid = table.Column<int>(type: "int", nullable: true),
                    reasonid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TerminatedContracts_Contracts_contractid",
                        column: x => x.contractid,
                        principalTable: "Contracts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TerminatedContracts_Reasons_reasonid",
                        column: x => x.reasonid,
                        principalTable: "Reasons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchAgents_agentid",
                table: "BranchAgents",
                column: "agentid");

            migrationBuilder.CreateIndex(
                name: "IX_BranchAgents_branchid",
                table: "BranchAgents",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_agentid",
                table: "Contracts",
                column: "agentid");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_branchid",
                table: "Contracts",
                column: "branchid");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_riskid",
                table: "Contracts",
                column: "riskid");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_tariffid",
                table: "Contracts",
                column: "tariffid");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_typeInsuranceid",
                table: "Contracts",
                column: "typeInsuranceid");

            migrationBuilder.CreateIndex(
                name: "IX_TerminatedContracts_contractid",
                table: "TerminatedContracts",
                column: "contractid",
                unique: true,
                filter: "[contractid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TerminatedContracts_reasonid",
                table: "TerminatedContracts",
                column: "reasonid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchAgents");

            migrationBuilder.DropTable(
                name: "TerminatedContracts");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Reasons");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Risks");

            migrationBuilder.DropTable(
                name: "Tariffs");

            migrationBuilder.DropTable(
                name: "TypeInsurances");
        }
    }
}
