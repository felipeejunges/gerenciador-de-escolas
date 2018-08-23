using System;
using System.Collections.Generic;
using System.Linq;
using gerenciador_de_escolas.Models;
using gerenciador_de_escolas.Repository;
using gerenciador_de_escolas.Storer;
using gerenciador_de_escolas.Utils;
using gerenciador_de_escolas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_escolas.Controllers
{
    [Route("Escola")]
    public class EscolaController : Controller
    {
        private readonly EscolaStorer _escolaStorer;
        private readonly IRepository<Escola> _escolaRepository;

        private readonly Util _util;

        public EscolaController(EscolaStorer escolaStorer, IRepository<Escola> escolaRepository)
        {
            _escolaStorer = escolaStorer;
            _escolaRepository = escolaRepository;
            _util = new Util();
        }

        [Route("Index")]
        [Route("")]
        public IActionResult Index()
        {
            var escolas = _escolaRepository.All();
            var viewModels = escolas.Select(e => new EscolaViewModel
            {
                id = e.id,
                nome = e.nome,
                telefone = e.telefone,
                endereco = e.endereco,
                logomarca = e.logomarca
            });
            return View(viewModels);
        }

        [HttpPost("Remove/{id}")]
        public void Remove(int id)
        {
            Escola escola = _escolaRepository.getById(id);
            if (escola != null)
            {
                _escolaRepository.remove(id);
            }
        }

        [Route("Form/{id}")]
        [Route("Form")]
        [HttpGet]
        public IActionResult Form(int id)
        {
            if (id > 0)
            {
                var e = _escolaRepository.getById(id);
                var escolaViewModel = new EscolaViewModel
                {
                    id = e.id,
                    nome = e.nome,
                    telefone = e.telefone,
                    endereco = e.endereco,
                    logomarca = e.logomarca
                };
                return View(escolaViewModel);
            }
            return View();
        }


        [HttpPost("Form/{id}")]
        [HttpPost("Form")]
        public IActionResult Form(EscolaViewModel vm)
        {

            _escolaStorer.store(vm.id, vm.nome, vm.endereco, _util.onlyNumbers(vm.telefone), vm.logomarca);
            return View();
        }

    }
}