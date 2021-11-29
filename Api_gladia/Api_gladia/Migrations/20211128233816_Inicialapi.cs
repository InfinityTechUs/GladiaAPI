using Microsoft.EntityFrameworkCore.Migrations;

namespace Api_gladia.Migrations
{
    public partial class Inicialapi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items_Order",
                table: "Items_Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "tbl_user");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "tbl_product");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "tbl_order");

            migrationBuilder.RenameTable(
                name: "Items_Order",
                newName: "tbl_items_order");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "tbl_category");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "tbl_address");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_product",
                table: "tbl_product",
                column: "prod_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_order",
                table: "tbl_order",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_items_order",
                table: "tbl_items_order",
                column: "fk_id_prod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category",
                column: "category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_address",
                table: "tbl_address",
                column: "address_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_user",
                table: "tbl_user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_product",
                table: "tbl_product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_order",
                table: "tbl_order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_items_order",
                table: "tbl_items_order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_address",
                table: "tbl_address");

            migrationBuilder.RenameTable(
                name: "tbl_user",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "tbl_product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "tbl_order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "tbl_items_order",
                newName: "Items_Order");

            migrationBuilder.RenameTable(
                name: "tbl_category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "tbl_address",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "prod_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items_Order",
                table: "Items_Order",
                column: "fk_id_prod");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "address_id");
        }
    }
}
