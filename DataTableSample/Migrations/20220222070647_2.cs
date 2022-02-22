using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTableSample.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "TPDbSetObj");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "TPDbSetObj",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "TPDbSetObj",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BusNumber",
                table: "TPDbSetObj",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TPDbSetObj",
                table: "TPDbSetObj",
                column: "SeatNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TPDbSetObj",
                table: "TPDbSetObj");

            migrationBuilder.RenameTable(
                name: "TPDbSetObj",
                newName: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CustomerAddress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BusNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "SeatNumber");
        }
    }
}
