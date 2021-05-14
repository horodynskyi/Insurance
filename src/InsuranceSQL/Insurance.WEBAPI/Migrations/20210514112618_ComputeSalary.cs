using Microsoft.EntityFrameworkCore.Migrations;

namespace Insurance.WEBAPI.Migrations
{
    public partial class ComputeSalary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Agents",
                type: "float",
                nullable: false,
                computedColumnSql: "([dbo].[computeSalary]([Id]))",
                stored: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Єремій", "Громико" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Далемир", "Трясун" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Добромисла", "Тиндарей" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Ганна", "Коман" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Лідія", "Ярмак" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Ян", "Гаман" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Любозар", "Левадовська" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Гнат", "Пагутяк" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Соломія", "Слободян" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Ярина", "Лазірко" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Agents",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldComputedColumnSql: "([dbo].[computeSalary]([Id]))");

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Любодар", "Негода" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Зорина", "Степанець" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Антон", "Москалюк" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Натан", "Трублаєвська" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Антонія", "Цушко" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Назарій", "Балицька" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Боримир", "Мазун" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Немир", "Дмитрук" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Устим", "Латаний" });

            migrationBuilder.UpdateData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "SecondName" },
                values: new object[] { "Листвич", "Москаль" });
        }
    }
}
