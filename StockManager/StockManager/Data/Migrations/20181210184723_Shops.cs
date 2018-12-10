using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Data.Migrations
{
    public partial class Shops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WarehouseFax",
                table: "Warehouse",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 16);

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ShopUID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShopRef = table.Column<string>(maxLength: 10, nullable: false),
                    WarehouseName = table.Column<string>(maxLength: 10, nullable: false),
                    WarehouseStreet = table.Column<string>(maxLength: 60, nullable: true),
                    WarehouseArea = table.Column<string>(maxLength: 60, nullable: true),
                    WarehouseTown = table.Column<string>(maxLength: 60, nullable: true),
                    WarehousePostCode = table.Column<string>(maxLength: 11, nullable: true),
                    WarehouseTelephone = table.Column<string>(maxLength: 16, nullable: true),
                    WarehouseFax = table.Column<string>(maxLength: 16, nullable: true),
                    WarehouseMemo = table.Column<string>(nullable: true),
                    SHopType = table.Column<int>(nullable: false),
                    DefaultWarehouse = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ShopUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseFax",
                table: "Warehouse",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 16,
                oldNullable: true);
        }
    }
}
