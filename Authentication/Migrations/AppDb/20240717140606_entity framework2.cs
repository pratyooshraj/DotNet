using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class entityframework2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTable_DepartmentTable_DeptId",
                table: "EmployeeTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTable_DeptId",
                table: "EmployeeTable");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmployeeTable");

            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "EmployeeTable");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DOB",
                table: "EmployeeTable",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "EmployeeTable",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "EmployeeTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "EmployeeTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTable_DeptId",
                table: "EmployeeTable",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTable_DepartmentTable_DeptId",
                table: "EmployeeTable",
                column: "DeptId",
                principalTable: "DepartmentTable",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
