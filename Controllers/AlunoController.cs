using System;
using System.Collections.Generic;
using System.Linq;
using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;
using gerenciador_de_escolas.Storer;
using gerenciador_de_escolas.Utils;
using gerenciador_de_escolas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_turmas.Controllers
{
    [Route("Aluno")]
    public class AlunoController : Controller
    {
        private readonly AlunoStorer _alunoStorer;
        private readonly IRepository<Aluno> _alunoRepository;
        private readonly IRepository<Turma> _turmaRepository;
        private readonly Util _util;

        public AlunoController(AlunoStorer alunoStorer,
        IRepository<Aluno> alunoRepository,
        IRepository<Turma> turmaRepository)
        {
            _alunoStorer = alunoStorer;
            _alunoRepository = alunoRepository;
            _turmaRepository = turmaRepository;
            _util = new Util();
        }

        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            var alunos = _alunoRepository.All();
            if (alunos.Any())
            {
                var viewsModels = alunos.Select(a => new AlunoViewModel
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
                return View(viewsModels);
            }

            return View(new List<AlunoViewModel>());
        }

        [HttpPost("Remove/{id}")]
        public void Remove(int id)
        {
            Aluno aluno = _alunoRepository.getById(id);
            if (aluno != null)
            {
                _alunoRepository.remove(id);
            }
        }

        [Route("{id}")]
        [Route("get/{id}")]
        public IActionResult Get(int id)
        {
            var vm = pegarAluno(id);

            return View(vm);
        }


        [Route("Form/{id}")]
        [Route("Form")]
        [HttpGet]
        public IActionResult Form(int id)
        {
            var vm = pegarAluno(id);

            return View(vm);
        }

        private AlunoViewModel pegarAluno(int id) {
            var vm = new AlunoViewModel();
            var turmas = _turmaRepository.All();
            vm.turmas = turmas.Any()
            ? turmas.Select(e => new TurmaViewModel
            {
                id = e.id,
                nome = e.ano + " - " + e.nome + " (" + e.escola.nome + ")",
                ano = e.ano,
                escolaNome = e.escola.nome
            }) : new List<TurmaViewModel>();
            if (id > 0)
            {
                var a = _alunoRepository.getById(id);
                vm.id = a.id;
                vm.matricula = a.matricula;
                vm.nome = a.nome;
                vm.telefone = a.telefone;
                vm.endereco = a.endereco;
                vm.turmaId = a.turma.id;
            }
            return vm;
        }

        [HttpPost("Form/{id}")]
        [HttpPost("Form")]
        public IActionResult Form(AlunoViewModel vm)
        {
            _alunoStorer.store(vm.id, vm.nome, vm.matricula, _util.onlyNumbers(vm.telefone), vm.endereco, vm.turmaId);
            return RedirectToAction("Index");
        }

    }
}
