using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;

namespace gerenciador_de_escolas.Storer
{
    public class EscolaStorer
    {
         private readonly IRepository<Escola> _escolaRepository;

          public EscolaStorer(IRepository<Escola> escolaRepository)
        {
            _escolaRepository = escolaRepository;
        }

        public void store(int id, string nome, string endereco, string telefone, string logomarca) {
            var escola = _escolaRepository.getById(id);
            if(escola == null) {
                escola = new Escola(nome, endereco, telefone, logomarca);
                _escolaRepository.save(escola);
            } else escola.update(nome, endereco, telefone, logomarca);
        }
        
    }
}