using Microsoft.AspNetCore.Mvc;

namespace gerenciador_de_escolas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}