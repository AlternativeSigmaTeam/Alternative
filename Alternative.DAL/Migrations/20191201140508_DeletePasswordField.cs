using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alternative.DAL.Migrations
{
    public partial class DeletePasswordField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a41b1fd3-ef53-4411-a45d-7015071a19f4"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ae543975-27c6-4d8a-92db-eb2e35be7e12"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e5e1d2b8-56ca-4350-a620-35e12758784d"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("832e3a81-bfb2-42d2-bbdb-20e6cc091ccd"), "Admin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e7551d0b-80d9-415e-8c77-06185bdc782e"), "Student" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7ca42614-0d09-4a88-ab9b-1bd0b81cc8d1"), "Teacher" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7ca42614-0d09-4a88-ab9b-1bd0b81cc8d1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("832e3a81-bfb2-42d2-bbdb-20e6cc091ccd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e7551d0b-80d9-415e-8c77-06185bdc782e"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ae543975-27c6-4d8a-92db-eb2e35be7e12"), "Admin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a41b1fd3-ef53-4411-a45d-7015071a19f4"), "Student" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e5e1d2b8-56ca-4350-a620-35e12758784d"), "Teacher" });
        }
    }
}
