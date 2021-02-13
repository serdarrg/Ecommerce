using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecommerce.Migrations
{
    public partial class Ecommerce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: true),
                    CustomerPhone = table.Column<int>(type: "INTEGER", nullable: false),
                    Balance = table.Column<double>(type: "REAL", nullable: false),
                    CustomerOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    LastOrder = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Products = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SellerName = table.Column<string>(type: "TEXT", nullable: true),
                    StoreName = table.Column<string>(type: "TEXT", nullable: true),
                    SellerRating = table.Column<double>(type: "REAL", nullable: false),
                    ProductAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    WalletBalance = table.Column<double>(type: "REAL", nullable: false),
                    SellerCreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Revenue = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(type: "TEXT", nullable: false),
                    ProductPrice = table.Column<double>(type: "REAL", nullable: false),
                    ordersOrderID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Orders_ordersOrderID",
                        column: x => x.ordersOrderID,
                        principalTable: "Orders",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderDate", "Products" },
                values: new object[] { 1, new DateTime(2021, 2, 13, 2, 58, 4, 901, DateTimeKind.Local).AddTicks(4927), 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderDate", "Products" },
                values: new object[] { 2, new DateTime(2021, 2, 13, 2, 58, 4, 910, DateTimeKind.Local).AddTicks(7109), 2 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "OrderDate", "Products" },
                values: new object[] { 3, new DateTime(2021, 2, 13, 2, 58, 4, 910, DateTimeKind.Local).AddTicks(7213), 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductName", "ProductPrice", "ordersOrderID" },
                values: new object[] { 1, "Polo", 5.0, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductName", "ProductPrice", "ordersOrderID" },
                values: new object[] { 2, "CalvinKlein", 25.0, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductName", "ProductPrice", "ordersOrderID" },
                values: new object[] { 3, "Gucci", 50.0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ordersOrderID",
                table: "Products",
                column: "ordersOrderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
