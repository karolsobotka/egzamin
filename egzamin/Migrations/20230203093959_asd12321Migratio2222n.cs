using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace egzamin.Migrations
{
    public partial class asd12321Migratio2222n : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "IdTeam", "Deadline", "MyProperty", "Name" },
                values: new object[] { 1, new DateTime(2023, 2, 3, 10, 39, 59, 797, DateTimeKind.Local).AddTicks(7701), 0, "projekt 1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "IdTeam", "Deadline", "MyProperty", "Name" },
                values: new object[] { 2, new DateTime(2023, 2, 3, 10, 39, 59, 797, DateTimeKind.Local).AddTicks(7736), 0, "projekt 2" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "IdTeam", "Deadline", "MyProperty", "Name" },
                values: new object[] { 3, new DateTime(2023, 2, 3, 10, 39, 59, 797, DateTimeKind.Local).AddTicks(7738), 0, "projekt 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "IdTeam",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "IdTeam",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "IdTeam",
                keyValue: 3);
        }
    }
}
