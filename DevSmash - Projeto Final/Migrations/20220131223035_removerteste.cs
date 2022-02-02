using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DevSmash___Projeto_Final.Migrations
{
    public partial class removerteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teste",
                table: "servicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teste",
                table: "servicos",
                type: "longtext",
                nullable: false,
                collation: "utf8mb4_0900_ai_ci")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
