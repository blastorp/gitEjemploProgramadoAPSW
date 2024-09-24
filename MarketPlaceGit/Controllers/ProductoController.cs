using MarketPlaceGit.Data;
using MarketPlaceGit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MarketPlaceGit.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _db;
        // private readonly IHttpContextAccessor _context;

        public ProductoController(ApplicationDbContext db)
        {
            _db = db;
            //     _context = httpcontextAccesor;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AgregarProducto()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AgregarProducto(Producto obj)
        {

            obj.EstadoLogico = true;


            var parametros = new[]
        {
            new SqlParameter("@IdCategoria",  obj.IdCategoria),
            new SqlParameter("@Nombre",  obj.Nombre),
            new SqlParameter("@Descripcion",  obj.Descripcion),
            new SqlParameter("@UrlImagen",  obj.UrlImagen),
            new SqlParameter("@Precio",  obj.Precio),
            

        };

            try
            {
                _db.Database.ExecuteSqlRaw("EXEC productosAddProducto @IdCategoria, " +
                "@Nombre, @Descripcion, @UrlImagen, @Precio"
                , parametros);
                return RedirectToAction("ExitoRegistro");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, e.Message);
            }



            return RedirectToAction("Error", "Home");
        }

        public JsonResult ObtenerProductos()
        {
            string comSql = "select * from ProductosCat ";
            IEnumerable<ProductoCat> listaProv = _db.ProductosCat.FromSqlRaw(comSql);

            return Json(listaProv.ToList());
        }

        public IActionResult ExitoRegistro()
        {
            return View();
        }
    }
}
