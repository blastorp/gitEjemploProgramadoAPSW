using System.ComponentModel.DataAnnotations;

namespace MarketPlaceGit.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        public int? IdPadre { get; set; }

        public string NombreCategoria { get; set; }

        public bool EstadoLogico { get; set; }
    }
}
