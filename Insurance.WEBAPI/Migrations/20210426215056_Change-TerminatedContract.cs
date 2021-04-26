using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.WEBAPI.Migrations
{
    public partial class ChangeTerminatedContract : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TerminatedContracts_ContractId",
                table: "TerminatedContracts");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TerminatedContracts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TerminatedContracts",
                table: "TerminatedContracts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TerminatedContracts_ContractId",
                table: "TerminatedContracts",
                column: "ContractId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TerminatedContracts",
                table: "TerminatedContracts");

            migrationBuilder.DropIndex(
                name: "IX_TerminatedContracts_ContractId",
                table: "TerminatedContracts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TerminatedContracts");

            migrationBuilder.CreateIndex(
                name: "IX_TerminatedContracts_ContractId",
                table: "TerminatedContracts",
                column: "ContractId",
                unique: true,
                filter: "[ContractId] IS NOT NULL");
        }
    }
}
