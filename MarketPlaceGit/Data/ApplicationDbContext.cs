using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MarketPlaceGit.Models;
namespace MarketPlaceGit.Data;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<ProductoCat> ProductosCat { get; set; }
    public DbSet<Categoria> Variaciones { get; set; }
    public DbSet<Categoria> ValorVariacion { get; set; }


}
