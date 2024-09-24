using System.ComponentModel.DataAnnotations;

namespace MarketPlaceGit.Models
{
    public class ProductoCat
    {
        [Key]
        public int IdProducto { get; set; }

      

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string UrlImagen { get; set; }

        public decimal Precio { get; set; }

        public int CantidadVisitas { get; set; }

        public bool EstadoLogico { get; set; }

        public string NombreCategoria { get; set; }

    }
}
