using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.DataAccess.Migrations
{
    public partial class validateNeverAndnullableInProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_RawMaterials_RawMaterialId",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "RawMaterialId",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_RawMaterials_RawMaterialId",
                table: "Properties",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_RawMaterials_RawMaterialId",
                table: "Properties");

            migrationBuilder.AlterColumn<int>(
                name: "RawMaterialId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_RawMaterials_RawMaterialId",
                table: "Properties",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
