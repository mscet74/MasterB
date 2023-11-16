using MasterBurger.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MasterBurger.Data {
  public class ApplicationDbContext : IdentityDbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {
    }
    public DbSet<DadosUtilizador>? DadosUtilizador { get; set; }

    public DbSet<DadosUser>? DadosUser { get; set; }

    public DbSet<Categoria>? Categorias { get; set; }

  }
}