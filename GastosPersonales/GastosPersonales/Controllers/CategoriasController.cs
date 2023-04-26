using GastosPersonales.AccesoDatos.Data.IRepository;
using GastosPersonales.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GastosPersonales.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoriasController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> ListaCategorias()
        {
            return View(await _unitOfWork.Categoria.GetAll());
        }
        [HttpGet]
        public IActionResult CrearCategoria()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CrearCategoria(Categoria categoria)
        {
            if (!ModelState.IsValid)
                return View(categoria);
            if(await _unitOfWork.Categoria.Existe(categoria.NombreCategoria))
            {
                ViewData["NombreCtgExiste"] = "Esa categoría ya existe.";
                return View(categoria);
            }
            await _unitOfWork.Categoria.Add(categoria);
            await _unitOfWork.Save();
            return RedirectToAction(nameof(ListaCategorias));
        }
    }
}
