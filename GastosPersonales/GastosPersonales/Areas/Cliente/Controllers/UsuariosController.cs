using GastosPersonales.AccesoDatos.Data.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace GastosPersonales.Areas.Cliente.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UsuariosController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
