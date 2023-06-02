
using Microsoft.EntityFrameworkCore;
using Pelix.DAL.Entities;
using Pelix.DAL.Models;

namespace Pelix.DAL.Context
{
    public class PelixContext : DbContext
    {
        public PelixContext()
        {

        }

        public PelixContext(DbContextOptions<PelixContext> options) : base(options)
        {
        }
        #region "Registros"
        public DbSet<Pelicula> tPeliculas { get; set; }
        public DbSet<Rent> tAlquilerPeliculas { get; set; }
        public DbSet<Rol> tRols { get; set; }
        public DbSet<User> tUsers { get; set; }
        public DbSet<Sale> tVentaPeliculas { get; set; }
        #endregion
    }
}
