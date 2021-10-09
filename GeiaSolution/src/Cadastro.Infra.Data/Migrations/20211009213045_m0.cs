using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.Infra.Data.Migrations
{
    public partial class m0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    NumeroRegristro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DataValidade = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Preco = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Deleted = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
