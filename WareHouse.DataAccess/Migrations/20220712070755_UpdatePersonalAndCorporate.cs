using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WareHouse.DataAccess.Migrations
{
    public partial class UpdatePersonalAndCorporate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_accountBanks_AspNetUsers_OwnerAccountId",
                table: "accountBanks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_accountBanks",
                table: "accountBanks");

            migrationBuilder.DropIndex(
                name: "IX_accountBanks_OwnerAccountId",
                table: "accountBanks");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "OwnerAccountId",
                table: "accountBanks");

            migrationBuilder.RenameTable(
                name: "accountBanks",
                newName: "AccountBanks");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Suppliers",
                newName: "Type");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountBanks",
                table: "AccountBanks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Corporates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadquartersNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfEstablish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfCreateInDatabase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlWebsite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EcinimicCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountBankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Corporates_AccountBanks_AccountBankId",
                        column: x => x.AccountBankId,
                        principalTable: "AccountBanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CellularPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlWebsite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Township = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeNational = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountBankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personals_AccountBanks_AccountBankId",
                        column: x => x.AccountBankId,
                        principalTable: "AccountBanks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corporates_AccountBankId",
                table: "Corporates",
                column: "AccountBankId");

            migrationBuilder.CreateIndex(
                name: "IX_Personals_AccountBankId",
                table: "Personals",
                column: "AccountBankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Corporates");

            migrationBuilder.DropTable(
                name: "Personals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountBanks",
                table: "AccountBanks");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Suppliers");

            migrationBuilder.RenameTable(
                name: "AccountBanks",
                newName: "accountBanks");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Suppliers",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OwnerAccountId",
                table: "accountBanks",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_accountBanks",
                table: "accountBanks",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_accountBanks_OwnerAccountId",
                table: "accountBanks",
                column: "OwnerAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_accountBanks_AspNetUsers_OwnerAccountId",
                table: "accountBanks",
                column: "OwnerAccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
