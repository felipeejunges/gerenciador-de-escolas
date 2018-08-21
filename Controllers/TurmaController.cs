using System;
using gerenciador_de_escolas.Storer;
using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_escolas.Controllers
{
    public class TurmaController : Controller
    {
         private readonly TurmaStorer _turmaStorer;

         public TurmaController(TurmaStorer turmaStorer) {
            _turmaStorer = turmaStorer;
        }
        
    }
}