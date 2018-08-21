using gerenciador_de_escolas.Models;

namespace gerenciador_de_escolas.Repository
{
    public class TurmaRepository : Repository<Turma>
    {
        public TurmaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}