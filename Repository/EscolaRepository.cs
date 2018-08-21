using gerenciador_de_escolas.Models;

namespace gerenciador_de_escolas.Repository
{
    public class EscolaRepository : Repository<Escola>
    {
        public EscolaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}