using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockTracker.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ticker = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "id", "ticker" },
                values: new object[] { 1, "GME" });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "id", "ticker" },
                values: new object[] { 2, "AAPL" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");
        }
    }
}
