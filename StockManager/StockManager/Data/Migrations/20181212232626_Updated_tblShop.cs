using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Data.Migrations
{
    public partial class Updated_tblShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WarehouseTown",
                table: "Shop",
                newName: "ShopTown");

            migrationBuilder.RenameColumn(
                name: "WarehouseTelephone",
                table: "Shop",
                newName: "ShopTelephone");

            migrationBuilder.RenameColumn(
                name: "WarehouseStreet",
                table: "Shop",
                newName: "ShopStreet");

            migrationBuilder.RenameColumn(
                name: "WarehousePostCode",
                table: "Shop",
                newName: "ShopPostCode");

            migrationBuilder.RenameColumn(
                name: "WarehouseName",
                table: "Shop",
                newName: "ShopName");

            migrationBuilder.RenameColumn(
                name: "WarehouseMemo",
                table: "Shop",
                newName: "ShopMemo");

            migrationBuilder.RenameColumn(
                name: "WarehouseFax",
                table: "Shop",
                newName: "ShopFax");

            migrationBuilder.RenameColumn(
                name: "WarehouseArea",
                table: "Shop",
                newName: "ShopArea");

            migrationBuilder.RenameColumn(
                name: "DefaultWarehouse",
                table: "Shop",
                newName: "Clearance");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopTown",
                table: "Shop",
                newName: "WarehouseTown");

            migrationBuilder.RenameColumn(
                name: "ShopTelephone",
                table: "Shop",
                newName: "WarehouseTelephone");

            migrationBuilder.RenameColumn(
                name: "ShopStreet",
                table: "Shop",
                newName: "WarehouseStreet");

            migrationBuilder.RenameColumn(
                name: "ShopPostCode",
                table: "Shop",
                newName: "WarehousePostCode");

            migrationBuilder.RenameColumn(
                name: "ShopName",
                table: "Shop",
                newName: "WarehouseName");

            migrationBuilder.RenameColumn(
                name: "ShopMemo",
                table: "Shop",
                newName: "WarehouseMemo");

            migrationBuilder.RenameColumn(
                name: "ShopFax",
                table: "Shop",
                newName: "WarehouseFax");

            migrationBuilder.RenameColumn(
                name: "ShopArea",
                table: "Shop",
                newName: "WarehouseArea");

            migrationBuilder.RenameColumn(
                name: "Clearance",
                table: "Shop",
                newName: "DefaultWarehouse");
        }
    }
}
