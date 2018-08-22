using System;
using gerenciador_de_escolas.Config;
using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;

namespace gerenciador_de_escolas.Storer
{
    public class AlunoStorer
    {
        private readonly IRepository<Aluno> _alunoRepository;
        private readonly IRepository<Turma> _turmaRepository;

        public AlunoStorer(IRepository<Aluno> alunoRepository,
        IRepository<Turma> turmaRepository)
        {
            _turmaRepository = turmaRepository;
            _alunoRepository = alunoRepository;
        }

        public void store(int id, string nome, string matricula, string telefone, string endereco, int turmaID)
        {
            Turma turma = _turmaRepository.getById(turmaID);
            DomainException.when(turma == null, "Escola é invalida");

            Aluno aluno = _alunoRepository.getById(id);
            if (turma == null)
            {
                aluno = new Aluno(nome, matricula, endereco, telefone, turma);
                _alunoRepository.save(aluno);
            }
            else
            {
                aluno.update(nome, matricula, endereco, telefone, turma);
            }
        }
    }
}
