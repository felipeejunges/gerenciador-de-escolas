using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gerenciadordeescolas.Migrations
{
    public partial class alunos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alunos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    matricula = table.Column<string>(nullable: true),
                    endereco = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    turmaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alunos", x => x.id);
                    table.ForeignKey(
                        name: "FK_alunos_turmas_turmaid",
                        column: x => x.turmaid,
                        principalTable: "turmas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alunos_turmaid",
                table: "alunos",
                column: "turmaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alunos");
        }
    }
}
