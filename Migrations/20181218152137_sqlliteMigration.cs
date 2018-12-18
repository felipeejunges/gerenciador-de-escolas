using Microsoft.EntityFrameworkCore.Migrations;

namespace gerenciadordeescolas.Migrations
{
    public partial class sqlliteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "escolas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true),
                    endereco = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    logomarca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_escolas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "turmas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(nullable: true),
                    ano = table.Column<string>(nullable: true),
                    escolaid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_turmas", x => x.id);
                    table.ForeignKey(
                        name: "FK_turmas_escolas_escolaid",
                        column: x => x.escolaid,
                        principalTable: "escolas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "alunos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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

            migrationBuilder.CreateIndex(
                name: "IX_turmas_escolaid",
                table: "turmas",
                column: "escolaid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alunos");

            migrationBuilder.DropTable(
                name: "turmas");

            migrationBuilder.DropTable(
                name: "escolas");
        }
    }
}
