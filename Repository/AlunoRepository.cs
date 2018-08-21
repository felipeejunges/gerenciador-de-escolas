using gerenciador_de_escolas.Models;

namespace gerenciador_de_escolas.Repository
{
    public class AlunoRepository : Repository<Aluno>
    {
        public AlunoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}