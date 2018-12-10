using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Data.Migrations
{
    public partial class AddWarehous : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    WarehouseUID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WarehouseRef = table.Column<string>(maxLength: 10, nullable: false),
                    WarehouseName = table.Column<string>(maxLength: 60, nullable: false),
                    WarehouseStreet = table.Column<string>(maxLength: 60, nullable: true),
                    WarehouseArea = table.Column<string>(maxLength: 60, nullable: true),
                    WarehouseTown = table.Column<string>(maxLength: 60, nullable: true),
                    WarehousePostCode = table.Column<string>(maxLength: 11, nullable: true),
                    WarehouseTelephone = table.Column<string>(maxLength: 16, nullable: true),
                    WarehouseFax = table.Column<string>(maxLength: 16, nullable: false),
                    WarehouseMemo = table.Column<string>(nullable: true),
                    WarehouseType = table.Column<int>(nullable: false),
                    DefaultWarehouse = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.WarehouseUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Warehouse");
        }
    }
}
