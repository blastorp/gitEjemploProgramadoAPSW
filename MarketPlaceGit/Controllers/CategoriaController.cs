using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MarketPlaceGit.Models;
using System.Numerics;
using MarketPlaceGit.Data;
using Microsoft.EntityFrameworkCore;

namespace MarketPlaceGit.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _db;
       // private readonly IHttpContextAccessor _context;

        public CategoriaController(ApplicationDbContext db)
        {
            _db = db;
       //     _context = httpcontextAccesor;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AgregarCategoria()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarCategoria(Categoria obj)
        {

            obj.EstadoLogico = true;


            var parametros = new[]
        {
            new SqlParameter("@Nombre", obj.NombreCategoria),
            
        };

            try
            {
                _db.Database.ExecuteSqlRaw("EXEC addCategoria @Nombre" 
                , parametros);
                return RedirectToAction("ExitoRegistro");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
            }



            return RedirectToAction("Error", "Home");
        }

        public JsonResult ObtenerCategorias()
        {
            string comSql = "Exec listarCategorias";
            IEnumerable<Categoria> listaProv = _db.Categorias.FromSqlRaw(comSql);

            return Json(listaProv.ToList());
        }
        public IActionResult ExitoRegistro()
        {
            return View();
        }

    }
}
