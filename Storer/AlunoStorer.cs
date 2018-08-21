using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;

namespace gerenciador_de_escolas.Storer
{
    public class AlunoStorer
    {
         private readonly IRepository<Aluno> _alunoRepository;

          public AlunoStorer(IRepository<Aluno> alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        
    }
}