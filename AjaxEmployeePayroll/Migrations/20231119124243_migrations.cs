using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AjaxEmployeePayroll.Migrations
{
    public partial class migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpTable",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProfileImage = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Salary = table.Column<decimal>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpTable", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpTable");
        }
    }
}
