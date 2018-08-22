using System;
using gerenciador_de_escolas.Storer;
using gerenciador_de_escolas.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_escolas.Controllers
{
    [Route("Aluno")]
    public class AlunoController : Controller
    {
        private readonly AlunoStorer _alunoStorer;

        public AlunoController(AlunoStorer alunoStorer)
        {
            _alunoStorer = alunoStorer;
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
        public IActionResult Form(AlunoViewModel vm)
        {
           _alunoStorer.store(vm.id, vm.nome, vm.matricula, vm.telefone, vm.endereco, vm.turma);
            return View();
        }

    }
}
