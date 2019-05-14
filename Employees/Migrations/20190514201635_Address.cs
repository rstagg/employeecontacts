using Microsoft.EntityFrameworkCore.Migrations;

namespace Employees.Migrations
{
    public partial class Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Emoloyees_EmployeeId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emoloyees",
                table: "Emoloyees");

            migrationBuilder.RenameTable(
                name: "Emoloyees",
                newName: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZIP",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_EmployeeId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ZIP",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Emoloyees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emoloyees",
                table: "Emoloyees",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Emoloyees_EmployeeId",
                table: "Departments",
                column: "EmployeeId",
                principalTable: "Emoloyees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
