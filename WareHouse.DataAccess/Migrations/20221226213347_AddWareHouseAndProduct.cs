using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.DataAccess.Migrations
{
    public partial class AddWareHouseAndProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "RawMaterials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssemblyPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductRawMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRawMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRawMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRawMaterials_RawMaterials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "RawMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListOfProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Numbers = table.Column<int>(type: "int", nullable: false),
                    PlaceOfSavedId = table.Column<int>(type: "int", nullable: false),
                    WareHouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListOfProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListOfProducts_WareHouses_WareHouseId",
                        column: x => x.WareHouseId,
                        principalTable: "WareHouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_ProductId",
                table: "RawMaterials",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfProducts_ProductId",
                table: "ListOfProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ListOfProducts_WareHouseId",
                table: "ListOfProducts",
                column: "WareHouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRawMaterials_MaterialId",
                table: "ProductRawMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRawMaterials_ProductId",
                table: "ProductRawMaterials",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterials_Products_ProductId",
                table: "RawMaterials",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterials_Products_ProductId",
                table: "RawMaterials");

            migrationBuilder.DropTable(
                name: "ListOfProducts");

            migrationBuilder.DropTable(
                name: "ProductRawMaterials");

            migrationBuilder.DropTable(
                name: "WareHouses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropIndex(
                name: "IX_RawMaterials_ProductId",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "RawMaterials");
        }
    }
}
