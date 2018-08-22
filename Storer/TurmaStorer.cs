using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;

namespace gerenciador_de_escolas.Storer
{
    public class TurmaStorer
    {
         private readonly IRepository<Turma> _turmaRepository;

          public TurmaStorer(IRepository<Turma> turmaRepository)
        {
            _turmaRepository = turmaRepository;
        }
        
    }
}