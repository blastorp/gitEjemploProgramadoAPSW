using System.ComponentModel.DataAnnotations;
namespace MarketPlaceGit.Models
{
    public class ValorVariacion
    {
        [Key]
        public int IdValor { get; set; }

        public string Valor { get; set; }

        public int IdVariacion { get; set; }

        public bool EstadoLogico { get; set; }
    }
}
