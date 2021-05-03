using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DPBack.Domain.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document_DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document_DocumentType = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Coat = table.Column<int>(type: "int", nullable: false),
                    Personality = table.Column<int>(type: "int", nullable: false),
                    Name_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NascimentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Specie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
