using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alternative.DAL.Migrations
{
    public partial class sffe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Teachers_TeacherId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_TeacherId",
                table: "User");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("66ef4fe0-2622-4c32-a32f-8ef2dc878869"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c20fb7cf-0704-45b2-98a7-dfaab08f2fb6"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c5c7231f-f949-4f73-a0d1-6dca851d1bba"));

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "User");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Teachers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("e698be24-5f37-4bfd-bbee-b3e6f1b7abd8"), "7ae13e96-5b72-4116-a5c9-2dbaab4f87ac", null, null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("25a5086c-0ee9-4f56-970e-9cb76929cb97"), "c398b081-621b-4610-ba83-aeb6c103e4b6", null, null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("9ead58a4-cf4c-494f-b06a-378fbf107618"), "2a8cf723-24f6-4008-9c4f-6cbd28c48130", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_User_UserId",
                table: "Teachers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_User_UserId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("25a5086c-0ee9-4f56-970e-9cb76929cb97"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9ead58a4-cf4c-494f-b06a-378fbf107618"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e698be24-5f37-4bfd-bbee-b3e6f1b7abd8"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Teachers");

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                table: "User",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("66ef4fe0-2622-4c32-a32f-8ef2dc878869"), "cf4f4927-c66a-4993-8d0a-1d3864f6e70c", null, null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("c5c7231f-f949-4f73-a0d1-6dca851d1bba"), "0600c27f-82e0-4ad5-b8b1-a49454a2adea", null, null });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("c20fb7cf-0704-45b2-98a7-dfaab08f2fb6"), "7ebb7116-c735-406c-861e-a7cb768596f9", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_User_TeacherId",
                table: "User",
                column: "TeacherId",
                unique: true,
                filter: "[TeacherId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Teachers_TeacherId",
                table: "User",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
