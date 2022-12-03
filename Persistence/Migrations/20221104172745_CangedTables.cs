using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class CangedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Employees_CorrespondentId",
                table: "Performers");

            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Positions_PositionId",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "PerformerEmail",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "PerformerFirstName",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "PerformerLastName",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "PerformerPhoneNumber",
                table: "Performers");

            migrationBuilder.DropColumn(
                name: "PerformerPotronymic",
                table: "Performers");

            migrationBuilder.RenameColumn(
                name: "NumberCorrespondent",
                table: "Performers",
                newName: "PerformerType");

            migrationBuilder.RenameColumn(
                name: "CorrespondentId",
                table: "Performers",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Performers_CorrespondentId",
                table: "Performers",
                newName: "IX_Performers_EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Potronymic",
                table: "Employees",
                newName: "Middle");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Agreements",
                newName: "Commment");

            migrationBuilder.RenameColumn(
                name: "DateSoglosovaniya",
                table: "Agreements",
                newName: "DateOfSendingAgreement");

            migrationBuilder.RenameColumn(
                name: "DateOtprovkaNaSoglosovaniya",
                table: "Agreements",
                newName: "DateAgreementDocument");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Performers",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Employees",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(75)",
                oldMaxLength: 75);

            migrationBuilder.AddColumn<int>(
                name: "CorrespondentId",
                table: "Documents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberCorrespondent",
                table: "Documents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PerformerPhoneNumber",
                table: "Documents",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_CorrespondentId",
                table: "Documents",
                column: "CorrespondentId");

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_AgreementEmployeeId",
                table: "Agreements",
                column: "AgreementEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agreements_Employees_AgreementEmployeeId",
                table: "Agreements",
                column: "AgreementEmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Employees_CorrespondentId",
                table: "Documents",
                column: "CorrespondentId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Employees_EmployeeId",
                table: "Performers",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Positions_PositionId",
                table: "Performers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agreements_Employees_AgreementEmployeeId",
                table: "Agreements");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Employees_CorrespondentId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Employees_EmployeeId",
                table: "Performers");

            migrationBuilder.DropForeignKey(
                name: "FK_Performers_Positions_PositionId",
                table: "Performers");

            migrationBuilder.DropIndex(
                name: "IX_Documents_CorrespondentId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Agreements_AgreementEmployeeId",
                table: "Agreements");

            migrationBuilder.DropColumn(
                name: "CorrespondentId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "NumberCorrespondent",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "PerformerPhoneNumber",
                table: "Documents");

            migrationBuilder.RenameColumn(
                name: "PerformerType",
                table: "Performers",
                newName: "NumberCorrespondent");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Performers",
                newName: "CorrespondentId");

            migrationBuilder.RenameIndex(
                name: "IX_Performers_EmployeeId",
                table: "Performers",
                newName: "IX_Performers_CorrespondentId");

            migrationBuilder.RenameColumn(
                name: "Middle",
                table: "Employees",
                newName: "Potronymic");

            migrationBuilder.RenameColumn(
                name: "DateOfSendingAgreement",
                table: "Agreements",
                newName: "DateSoglosovaniya");

            migrationBuilder.RenameColumn(
                name: "DateAgreementDocument",
                table: "Agreements",
                newName: "DateOtprovkaNaSoglosovaniya");

            migrationBuilder.RenameColumn(
                name: "Commment",
                table: "Agreements",
                newName: "Description");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "Performers",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PerformerEmail",
                table: "Performers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PerformerFirstName",
                table: "Performers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PerformerLastName",
                table: "Performers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PerformerPhoneNumber",
                table: "Performers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PerformerPotronymic",
                table: "Performers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "character varying(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(13)",
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Employees",
                type: "character varying(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Employees_CorrespondentId",
                table: "Performers",
                column: "CorrespondentId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Performers_Positions_PositionId",
                table: "Performers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
