using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agreements_Departments_DepartmentId",
                table: "Agreements");

            migrationBuilder.DropIndex(
                name: "IX_Agreements_DepartmentId",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Agreements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Agreements",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_DepartmentId",
                table: "Agreements",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agreements_Departments_DepartmentId",
                table: "Agreements",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
