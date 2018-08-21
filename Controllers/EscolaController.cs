using System;
using gerenciador_de_escolas.Storer;
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
        
    }
}