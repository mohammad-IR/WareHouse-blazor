using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.DataAccess.Migrations
{
    public partial class UpdateCuurencyAndDifereceIsBaseCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterials_CurrenciesPrice_CurrencyPriceId",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "PriceIR",
                table: "RawMaterials");

            migrationBuilder.DropColumn(
                name: "RialValue",
                table: "CurrenciesPrice");

            migrationBuilder.RenameColumn(
                name: "CurrencyPriceId",
                table: "RawMaterials",
                newName: "CurrencyPriceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_RawMaterials_CurrencyPriceId",
                table: "RawMaterials",
                newName: "IX_RawMaterials_CurrencyPriceTypeId");

            migrationBuilder.AlterColumn<double>(
                name: "CurrencyPrice",
                table: "RawMaterials",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<double>(
                name: "BaseCurrencyValue",
                table: "CurrenciesPrice",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "BaseSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyPriceBaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseSettings_CurrenciesPrice_CurrencyPriceBaseId",
                        column: x => x.CurrencyPriceBaseId,
                        principalTable: "CurrenciesPrice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterialProperties_PropertyId",
                table: "RawMaterialProperties",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterialProperties_RawMaterialId",
                table: "RawMaterialProperties",
                column: "RawMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseSettings_CurrencyPriceBaseId",
                table: "BaseSettings",
                column: "CurrencyPriceBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterialProperties_Properties_PropertyId",
                table: "RawMaterialProperties",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterialProperties_RawMaterials_RawMaterialId",
                table: "RawMaterialProperties",
                column: "RawMaterialId",
                principalTable: "RawMaterials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterials_CurrenciesPrice_CurrencyPriceTypeId",
                table: "RawMaterials",
                column: "CurrencyPriceTypeId",
                principalTable: "CurrenciesPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterialProperties_Properties_PropertyId",
                table: "RawMaterialProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterialProperties_RawMaterials_RawMaterialId",
                table: "RawMaterialProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_RawMaterials_CurrenciesPrice_CurrencyPriceTypeId",
                table: "RawMaterials");

            migrationBuilder.DropTable(
                name: "BaseSettings");

            migrationBuilder.DropIndex(
                name: "IX_RawMaterialProperties_PropertyId",
                table: "RawMaterialProperties");

            migrationBuilder.DropIndex(
                name: "IX_RawMaterialProperties_RawMaterialId",
                table: "RawMaterialProperties");

            migrationBuilder.DropColumn(
                name: "BaseCurrencyValue",
                table: "CurrenciesPrice");

            migrationBuilder.RenameColumn(
                name: "CurrencyPriceTypeId",
                table: "RawMaterials",
                newName: "CurrencyPriceId");

            migrationBuilder.RenameIndex(
                name: "IX_RawMaterials_CurrencyPriceTypeId",
                table: "RawMaterials",
                newName: "IX_RawMaterials_CurrencyPriceId");

            migrationBuilder.AlterColumn<float>(
                name: "CurrencyPrice",
                table: "RawMaterials",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<long>(
                name: "PriceIR",
                table: "RawMaterials",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RialValue",
                table: "CurrenciesPrice",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddForeignKey(
                name: "FK_RawMaterials_CurrenciesPrice_CurrencyPriceId",
                table: "RawMaterials",
                column: "CurrencyPriceId",
                principalTable: "CurrenciesPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
