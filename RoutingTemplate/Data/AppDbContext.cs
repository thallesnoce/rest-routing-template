using Microsoft.EntityFrameworkCore;
using RoutingTemplate.Models;

namespace RoutingTemplate.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Chefe> Chefes => Set<Chefe>();
    public DbSet<Subordinado> Subordinados => Set<Subordinado>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Chefe>().HasData(
            new Chefe { Id = 1, Nome = "Ana Lima",    Departamento = "Engenharia" },
            new Chefe { Id = 2, Nome = "Bruno Costa",  Departamento = "Marketing"  }
        );

        modelBuilder.Entity<Subordinado>().HasData(
            new Subordinado { Id = 1, Nome = "Carlos Souza",  Cargo = "Dev Junior",    ChefeId = 1 },
            new Subordinado { Id = 2, Nome = "Diana Ferreira", Cargo = "Dev Pleno",    ChefeId = 1 },
            new Subordinado { Id = 3, Nome = "Eduardo Nunes",  Cargo = "Designer",     ChefeId = 2 },
            new Subordinado { Id = 4, Nome = "Fernanda Alves", Cargo = "Copywriter",   ChefeId = 2 }
        );
    }
}
