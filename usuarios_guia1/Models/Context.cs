using Microsoft.EntityFrameworkCore;

namespace usuarios_guia1.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Conocimientos> conocimientos { get; set; }

    }
}
