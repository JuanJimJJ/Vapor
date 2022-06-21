using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VaporApp.Infrastructure.Migrations
{
    public partial class DBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    IdCategory = table.Column<int>(nullable: false),
                    CategoryName = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__CBD74706984C2209", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    ProductPrice = table.Column<double>(nullable: false),
                    ProductSku = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    ProductStock = table.Column<short>(nullable: false),
                    ProductReview = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__2E8946D499A458F6", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false),
                    UserFirstName = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    UserMiddleName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    UserLastName = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    UserEmail = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    UserPhone = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    UserAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    UserCity = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    UserState = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    UserCountry = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    UserZIPCode = table.Column<string>(unicode: false, maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__B7C92638C0C46A3E", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    IdProductCategory = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    IdCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ProductC__94B65A4226FE35B8", x => x.IdProductCategory);
                    table.ForeignKey(
                        name: "FK__ProductCa__IdCat__403A8C7D",
                        column: x => x.IdCategory,
                        principalTable: "Categories",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__ProductCa__IdPro__3F466844",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false),
                    IdUser = table.Column<int>(nullable: false),
                    OrderShippingAddress = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    OrderZipCode = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    OrderCity = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    OrderState = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    OrderCountry = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__C38F300902C34BB8", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK__Orders__IdUser__38996AB5",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    IdOrderDetails = table.Column<int>(nullable: false),
                    DetailAmount = table.Column<short>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    IdOrder = table.Column<int>(nullable: false),
                    DetailPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderDet__8D4849D6D8A882DE", x => x.IdOrderDetails);
                    table.ForeignKey(
                        name: "FK__OrderDeta__IdOrd__3B75D760",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "IdOrder",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__OrderDeta__IdPro__3C69FB99",
                        column: x => x.IdProduct,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IdOrder",
                table: "OrderDetails",
                column: "IdOrder");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IdProduct",
                table: "OrderDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_IdUser",
                table: "Orders",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_IdCategory",
                table: "ProductCategories",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_IdProduct",
                table: "ProductCategories",
                column: "IdProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
