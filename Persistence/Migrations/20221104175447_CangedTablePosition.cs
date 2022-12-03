using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CangedTablePosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Addresses_AddressId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Addresses_AddressId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Positions_PositionId",
                table: "Performers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Performers_PositionId",
                table: "Performers");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AddressId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departments_AddressId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Departments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Performers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Employees",
                type: "integer",
                maxLength: 75,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Departments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Performers_PositionId",
                table: "Performers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AddressId",
                table: "Employees",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_AddressId",
                table: "Departments",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Addresses_AddressId",
                table: "Departments",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Addresses_AddressId",
                table: "Employees",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Positions_PositionId",
                table: "Performers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id");
        }
    }
}
