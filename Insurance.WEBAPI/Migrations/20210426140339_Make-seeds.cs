using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.WEBAPI.Migrations
{
    public partial class Makeseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "FirstName", "Patronumic", "Salary", "SecondName" },
                values: new object[,]
                {
                    { 1, "Maksym", "Victorovich", 10000m, "Horodynksyi" },
                    { 2, "Eugen", "Ihorovich", 100000m, "Pronin" }
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "Id", "Address", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "st. Holovna 27", "Insurance of Dangeon Master", "+380505553535" },
                    { 2, "st. Haharina 75", "Best Insurance ", "+380957456258" }
                });

            migrationBuilder.InsertData(
                table: "Reasons",
                columns: new[] { "Id", "Name", "Paid" },
                values: new object[,]
                {
                    { 1, "Died", 0.75f },
                    { 2, "Insurance time expired", 0.75f }
                });

            migrationBuilder.InsertData(
                table: "Risks",
                columns: new[] { "Id", "Sum" },
                values: new object[,]
                {
                    { 1, 300m },
                    { 2, 800m }
                });

            migrationBuilder.InsertData(
                table: "Tariffs",
                columns: new[] { "Id", "WageRate" },
                values: new object[,]
                {
                    { 1, 30m },
                    { 2, 50m }
                });

            migrationBuilder.InsertData(
                table: "TypeInsurances",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "House" },
                    { 2, "Life" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reasons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Risks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tariffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypeInsurances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypeInsurances",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
