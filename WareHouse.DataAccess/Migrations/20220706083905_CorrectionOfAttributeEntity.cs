using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.DataAccess.Migrations
{
    public partial class CorrectionOfAttributeEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtrributesProperties");

            migrationBuilder.CreateTable(
                name: "AttributesProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributesProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributesProperties_Properties_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributesProperties_IdProperty",
                table: "AttributesProperties",
                column: "IdProperty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributesProperties");

            migrationBuilder.CreateTable(
                name: "AtrributesProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProperty = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtrributesProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtrributesProperties_Properties_IdProperty",
                        column: x => x.IdProperty,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtrributesProperties_IdProperty",
                table: "AtrributesProperties",
                column: "IdProperty");
        }
    }
}
