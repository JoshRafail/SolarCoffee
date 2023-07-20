using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolarCoffee.Data.Migrations
{
    /// <inheritdoc />
    public partial class PrimaryAddressRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerAddresses_PrimaryAdressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductsInventory_Products_ProductId",
                table: "ProductsInventory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsInventory",
                table: "ProductsInventory");

            migrationBuilder.RenameTable(
                name: "ProductsInventory",
                newName: "ProductInventories");

            migrationBuilder.RenameColumn(
                name: "PrimaryAdressId",
                table: "Customers",
                newName: "PrimaryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_PrimaryAdressId",
                table: "Customers",
                newName: "IX_Customers_PrimaryAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsInventory_ProductId",
                table: "ProductInventories",
                newName: "IX_ProductInventories_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerAddresses_PrimaryAddressId",
                table: "Customers",
                column: "PrimaryAddressId",
                principalTable: "CustomerAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerAddresses_PrimaryAddressId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventories_Products_ProductId",
                table: "ProductInventories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductInventories",
                table: "ProductInventories");

            migrationBuilder.RenameTable(
                name: "ProductInventories",
                newName: "ProductsInventory");

            migrationBuilder.RenameColumn(
                name: "PrimaryAddressId",
                table: "Customers",
                newName: "PrimaryAdressId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_PrimaryAddressId",
                table: "Customers",
                newName: "IX_Customers_PrimaryAdressId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductInventories_ProductId",
                table: "ProductsInventory",
                newName: "IX_ProductsInventory_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsInventory",
                table: "ProductsInventory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerAddresses_PrimaryAdressId",
                table: "Customers",
                column: "PrimaryAdressId",
                principalTable: "CustomerAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsInventory_Products_ProductId",
                table: "ProductsInventory",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
