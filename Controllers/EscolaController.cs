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

         public IActionResult Index()
        {
            return View();
        }


        [Route("Form")]
        public IActionResult Form()
        {
            return View();
        }

        
        [HttpPost("Form")]
        public IActionResult Form(EscolaViewModel viewsModels)
        {
            //_categoryStorer.store(viewsModels.id, viewsModels.nome);
            return View();
        }
        
    }
}