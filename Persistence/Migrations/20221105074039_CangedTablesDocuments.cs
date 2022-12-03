using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CangedTablesDocuments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Departments_DepartmentId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_DepartmentId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Documents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Documents",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DepartmentId",
                table: "Documents",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Departments_DepartmentId",
                table: "Documents",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
