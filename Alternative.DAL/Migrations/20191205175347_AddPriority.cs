using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alternative.DAL.Migrations
{
    public partial class AddPriority : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<short>(
                name: "Priority",
                table: "UsersAlternativeses",
                nullable: false,
                defaultValue: (short)0);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "UsersAlternativeses");
        }
    }
}
