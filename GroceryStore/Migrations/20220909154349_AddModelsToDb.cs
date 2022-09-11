using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStore.Migrations
{
    public partial class AddModelsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    HomeNo = table.Column<byte>(nullable: true),
                    TazkiraNo = table.Column<int>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConfirmPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "itemStoreKeeper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RealPrice = table.Column<int>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    MadeIn = table.Column<string>(nullable: true),
                    Type = table.Column<byte>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    ExpireDate = table.Column<DateTime>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Profit = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itemStoreKeeper", x => x.Id);
                    table.ForeignKey(
                        name: "FK_itemStoreKeeper_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(nullable: true),
                    Profit = table.Column<int>(nullable: true),
                    Discount = table.Column<int>(nullable: true),
                    ItemStoreKepeerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_itemStoreKeeper_ItemStoreKepeerId",
                        column: x => x.ItemStoreKepeerId,
                        principalTable: "itemStoreKeeper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<float>(nullable: true),
                    Amount = table.Column<float>(nullable: true),
                    ItemId = table.Column<int>(nullable: true),
                    ItemStoreKeeperId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemDetail_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDetail_itemStoreKeeper_ItemStoreKeeperId",
                        column: x => x.ItemStoreKeeperId,
                        principalTable: "itemStoreKeeper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    ItemDetailId = table.Column<int>(nullable: true),
                    ItemId = table.Column<int>(nullable: true),
                    ItemStoreKeeperId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chart_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chart_ItemDetail_ItemDetailId",
                        column: x => x.ItemDetailId,
                        principalTable: "ItemDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chart_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chart_itemStoreKeeper_ItemStoreKeeperId",
                        column: x => x.ItemStoreKeeperId,
                        principalTable: "itemStoreKeeper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chart_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chart_CategoryId",
                table: "Chart",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Chart_ItemDetailId",
                table: "Chart",
                column: "ItemDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Chart_ItemId",
                table: "Chart",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Chart_ItemStoreKeeperId",
                table: "Chart",
                column: "ItemStoreKeeperId");

            migrationBuilder.CreateIndex(
                name: "IX_Chart_UserId",
                table: "Chart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemStoreKepeerId",
                table: "Item",
                column: "ItemStoreKepeerId",
                unique: true,
                filter: "[ItemStoreKepeerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDetail_ItemId",
                table: "ItemDetail",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDetail_ItemStoreKeeperId",
                table: "ItemDetail",
                column: "ItemStoreKeeperId");

            migrationBuilder.CreateIndex(
                name: "IX_itemStoreKeeper_CategoryId",
                table: "itemStoreKeeper",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chart");

            migrationBuilder.DropTable(
                name: "ItemDetail");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "itemStoreKeeper");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
