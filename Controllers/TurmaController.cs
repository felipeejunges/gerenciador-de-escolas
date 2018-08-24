using System;
using System.Collections.Generic;
using System.Linq;
using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;
using gerenciador_de_escolas.Storer;
using gerenciador_de_escolas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_Turmas.Controllers
{
    [Route("Turma")]
    public class TurmaController : Controller
    {
        private readonly TurmaStorer _turmaStorer;
        private readonly IRepository<Turma> _turmaRepository;
        private readonly IRepository<Escola> _escolaRepository;
        private readonly IRepository<Aluno> _alunoRepository;

        public TurmaController(TurmaStorer turmaStorer,
        IRepository<Turma> turmaRepository,
        IRepository<Escola> escolaRepository,
        IRepository<Aluno> alunoRepository)
        {
            _turmaStorer = turmaStorer;
            _turmaRepository = turmaRepository;
            _escolaRepository = escolaRepository;
            _alunoRepository = alunoRepository;
        }

        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            var turmas = _turmaRepository.All();
            if (turmas.Any())
            {
                var viewsModels = turmas.Select(t => new TurmaViewModel { 
                    id = t.id, 
                    nome = t.nome, 
                    ano = t.ano, 
                    escolaNome = t.escola.nome
                    });
                return View(viewsModels);
            }

            return View(new List<TurmaViewModel>());
        }

        [HttpPost("Remove/{id}")]
        public void Remove(int id)
        {
            Turma Turma = _turmaRepository.getById(id);
            if (Turma != null)
            {
                _turmaRepository.remove(id);
            }
        }

        [Route("get/{id}")]
        [Route("{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            var vm = pegarTurma(id);
            var alunos = _alunoRepository.getByFK(id);
            if (alunos.Any())
            {
                vm.alunos = alunos.Select(a => new AlunoViewModel
                {
                    id = a.id,
                    matricula = a.matricula,
                    nome = a.nome,
                    telefone = a.telefone,
                    endereco = a.endereco,
                    turmaNome = a.turma.nome,
                    turmaAno = a.turma.ano,
                    escolaNome = a.turma.escola.nome
                });
            } else {
                vm.alunos = new List<AlunoViewModel>();
            }
            return View(vm);
        }

        [Route("Form/{id}")]
        [Route("Form")]
        [HttpGet]
        public IActionResult Form(int id)
        {
            return View(pegarTurma(id));
        }

        private TurmaViewModel pegarTurma(int id) {
            var turmaViewModel = new TurmaViewModel();
            var escolas = _escolaRepository.All();
            turmaViewModel.escolas = escolas.Any()
            ? escolas.Select(e => new EscolaViewModel
            {
                id = e.id,
                nome = e.nome
            }) : new List<EscolaViewModel>();
            if (id > 0)
            {
                var t = _turmaRepository.getById(id);
                turmaViewModel.id = t.id;
                turmaViewModel.ano = t.ano;
                turmaViewModel.nome = t.nome;
                turmaViewModel.escolaId = t.escola.id;
            }
            return turmaViewModel;
        }

        [HttpPost("Form/{id}")]
        [HttpPost("Form")]
        public IActionResult Form(TurmaViewModel vm)
        {
            _turmaStorer.store(vm.id, vm.nome, vm.ano, vm.escolaId);
            return RedirectToAction("Index");
        }

    }
}