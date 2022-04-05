using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockData.Worker.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stocks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIdid = table.Column<int>(type: "int", nullable: false),
                    LastTradingPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    High = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Low = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosePrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YesterdayClosePrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Change = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stocks", x => x.id);
                    table.ForeignKey(
                        name: "FK_stocks_companies_CompanyIdid",
                        column: x => x.CompanyIdid,
                        principalTable: "companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_stocks_CompanyIdid",
                table: "stocks",
                column: "CompanyIdid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stocks");

            migrationBuilder.DropTable(
                name: "companies");
        }
    }
}
