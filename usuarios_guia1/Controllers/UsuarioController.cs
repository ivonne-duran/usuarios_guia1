using Microsoft.AspNetCore.Mvc;

namespace usuarios_guia1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult guardar()
        {
            return View();
        }

    }
}
