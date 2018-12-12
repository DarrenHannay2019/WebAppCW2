using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Data.Migrations
{
    public partial class tblStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    StockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockCode = table.Column<string>(maxLength: 30, nullable: false),
                    SupplierRef = table.Column<int>(nullable: false),
                    DeadCode = table.Column<bool>(nullable: false),
                    Clearance = table.Column<bool>(nullable: false),
                    ZeroQty = table.Column<bool>(nullable: false),
                    Season = table.Column<int>(nullable: false),
                    AmtTaken = table.Column<decimal>(nullable: false),
                    DeliveredQty = table.Column<int>(nullable: false),
                    CostValue = table.Column<decimal>(nullable: false),
                    PCMarkUp = table.Column<decimal>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
