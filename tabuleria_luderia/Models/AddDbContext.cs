


using Microsoft.EntityFrameworkCore;

namespace tabuleria_luderia.Models
{
    public class AddDbContext : DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Jogo> Jogos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}

  