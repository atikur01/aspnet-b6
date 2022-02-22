using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTableSample.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    SeatNumber = table.Column<string>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    TicketPrice = table.Column<int>(nullable: false),
                    BusNumber = table.Column<string>(nullable: true),
                    OnboardingTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.SeatNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
