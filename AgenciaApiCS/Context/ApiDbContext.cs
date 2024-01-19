using AgenciaApiCS.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaApiCS.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) 
        { }

        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Hospedagem> Hospedagens { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
