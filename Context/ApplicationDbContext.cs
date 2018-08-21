using gerenciador_de_escolas.Models;
using Microsoft.EntityFrameworkCore;

namespace gerenciador_de_escolas.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> alunos { get; set; }
        public DbSet<Turma> turmas { get; set; }
        public DbSet<Escola> escolas { get; set; }
    }
}