using Microsoft.AspNetCore.Mvc;

namespace GastosPersonales.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
