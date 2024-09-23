using System.ComponentModel.DataAnnotations;

namespace MarketPlaceGit.Models
{
    public class Variaciones
    {
        [Key]
        public int IdVariacion { get; set; }

        public string Nombre { get; set; }

        public int IdProducto { get; set; }

        public bool EstadoLogico { get; set; }
    }
}
