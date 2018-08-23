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

        public TurmaController(TurmaStorer turmaStorer,
        IRepository<Turma> turmaRepository,
        IRepository<Escola> escolaRepository)
        {
            _turmaStorer = turmaStorer;
            _turmaRepository = turmaRepository;
            _escolaRepository = escolaRepository;
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

        [Route("Form/{id}")]
        [Route("Form")]
        [HttpGet]
        public IActionResult Form(int id)
        {
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
            return View(turmaViewModel);
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