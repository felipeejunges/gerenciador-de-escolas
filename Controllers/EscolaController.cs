using System;
using gerenciador_de_escolas.Storer;
using gerenciador_de_escolas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_escolas.Controllers
{
    [Route("Escola")]
    public class EscolaController : Controller
    {
         private readonly EscolaStorer _escolaStorer;

         public EscolaController(EscolaStorer escolaStorer) {
            _escolaStorer = escolaStorer;
        }

        [Route("Index")]
        [Route("Escola")]
         public IActionResult Index()
        {
            return View();
        }


        [Route("Form")]
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        
       [HttpPost("Form")]
        public IActionResult Form(EscolaViewModel vm)
        {
            
            _escolaStorer.store(vm.id, vm.nome, vm.endereco, vm.telefone, vm.logomarca);
            return View();
        }
        
    }
}