using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyEmployees.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[,]
                {
                    { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "10457 GumpForest Ave. Towson MD 21026", "USA", "Tha_Solutions Inc" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "123 Highway St. Baltimore MD 21203", "USA", "Jay_Solutions Inc" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), 34, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Sam Kc", "HR Administrator" },
                    { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 42, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Ram Bhandari", "Sonftware Engineer" },
                    { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 48, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Hari Bhandari", "Sonftware Developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("80abbca8-664d-4b20-b5de-024705497d4a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}
