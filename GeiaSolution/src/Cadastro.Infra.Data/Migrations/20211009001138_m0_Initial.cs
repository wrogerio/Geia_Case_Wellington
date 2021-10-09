using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro.Infra.Data.Migrations
{
    public partial class m0_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Produtos",
                table => new
                {
                    Id = table.Column<Guid>("uniqueidentifier"),
                    Nome = table.Column<string>("nvarchar(max)", nullable: true),
                    Empresa = table.Column<string>("nvarchar(70)", maxLength: 70),
                    NumeroRegristro = table.Column<string>("nvarchar(20)", maxLength: 20),
                    DataValidade = table.Column<DateTime>("DateTime"),
                    Preco = table.Column<double>("float(18)", precision: 18, scale: 2),
                    CreatedAt = table.Column<DateTime>("DateTime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>("DateTime"),
                    Deleted = table.Column<bool>("bit", nullable: false, defaultValue: false)
                },
                constraints: table => { table.PrimaryKey("PK_Produtos", x => x.Id); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Produtos");
        }
    }
}