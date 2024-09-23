using System.ComponentModel.DataAnnotations;

namespace MarketPlaceGit.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }

        public int IdCategoria { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string UrlImagen { get; set; }

        public decimal Precio { get; set; }

        public int CantidadVisitas { get; set; }

        public bool EstadoLogico { get; set; }
    }
}
