using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alternative.DAL.Migrations
{
    public partial class FixBag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_SpecialityCourseses_Id",
                table: "SpecialityCourseses");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("21c727c6-19c7-4aa1-b296-f0fa4a581048"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c6f8b750-c830-4788-a0db-6021723411d0"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cab3e5b4-63ac-49e0-a511-041de73e9f3a"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SpecialityCourseses");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "SpecialityCourseses",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddUniqueConstraint(
                name: "AK_SpecialityCourseses_Id",
                table: "SpecialityCourseses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("c6f8b750-c830-4788-a0db-6021723411d0"), "Admin" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("cab3e5b4-63ac-49e0-a511-041de73e9f3a"), "Student" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("21c727c6-19c7-4aa1-b296-f0fa4a581048"), "Teacher" });
        }
    }
}
