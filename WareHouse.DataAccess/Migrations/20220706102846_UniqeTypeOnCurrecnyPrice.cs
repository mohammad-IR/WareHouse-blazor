using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.DataAccess.Migrations
{
    public partial class UniqeTypeOnCurrecnyPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMaterial",
                table: "RawMaterials");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CurrenciesPrice",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CurrenciesPrice_Type",
                table: "CurrenciesPrice",
                column: "Type",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CurrenciesPrice_Type",
                table: "CurrenciesPrice");

            migrationBuilder.AddColumn<string>(
                name: "IdMaterial",
                table: "RawMaterials",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "CurrenciesPrice",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
