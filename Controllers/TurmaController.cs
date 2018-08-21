using System;
using gerenciador_de_escolas.Storer;
using gerenciador_de_escolas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_escolas.Controllers
{
    [Route("Turma")]
    public class TurmaController : Controller
    {
         private readonly TurmaStorer _turmaStorer;

         public TurmaController(TurmaStorer turmaStorer) {
            _turmaStorer = turmaStorer;
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
        public IActionResult Form(TurmaViewModel viewsModels)
        {
            //_categoryStorer.store(viewsModels.id, viewsModels.nome);
            return View();
        }
        
    }
}