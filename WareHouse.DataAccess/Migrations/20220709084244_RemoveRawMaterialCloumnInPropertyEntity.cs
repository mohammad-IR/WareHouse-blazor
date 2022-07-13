using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.DataAccess.Migrations
{
    public partial class RemoveRawMaterialCloumnInPropertyEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_RawMaterials_RawMaterialId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_RawMaterialId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "RawMaterialId",
                table: "Properties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RawMaterialId",
                table: "Properties",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_RawMaterialId",
                table: "Properties",
                column: "RawMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_RawMaterials_RawMaterialId",
                table: "Properties",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id");
        }
    }
}
