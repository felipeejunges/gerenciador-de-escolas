using System;
using gerenciador_de_escolas.Storer;
using gerenciador_de_escolas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_escolas.Controllers
{
    public class AlunoController : Controller
    {
        private readonly AlunoStorer _alunoStorer;

        public AlunoController(AlunoStorer alunoStorer)
        {
            _alunoStorer = alunoStorer;
        }

        [HttpGet("Aluno")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("Aluno/New")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("Aluno/New")]
        public IActionResult New(AlunoViewModel viewsModels)
        {
            //_categoryStorer.store(viewsModels.id, viewsModels.nome);
            return View();
        }

    }
}
