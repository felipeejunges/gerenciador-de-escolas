using System;
using gerenciador_de_escolas.Config;
using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;

namespace gerenciador_de_escolas.Storer
{
    public class TurmaStorer
    {
        private readonly IRepository<Turma> _turmaRepository;
        private readonly IRepository<Escola> _escolaRepository;

        public TurmaStorer(IRepository<Turma> turmaRepository, IRepository<Escola> escolaRepository)
        {
            _escolaRepository = escolaRepository;
            _turmaRepository = turmaRepository;
        }
        public void store(int id, string nome, string ano, int escolaId)
        {
            Escola escola = _escolaRepository.getById(escolaId);
            DomainException.when(escola == null, "Escola é invalida");

            Turma turma = _turmaRepository.getById(id);
            if(turma == null) {
                turma = new Turma(nome, ano, escola);
                _turmaRepository.save(turma);
            } else {
                turma.update(nome, ano, escola);
            }
        }
    }
}