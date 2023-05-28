
using Microsoft.EntityFrameworkCore;
using Pelix.DAL.Entities;

namespace Pelix.DAL.Context
{
    public class PelixContext : DbContext
    {
        public PelixContext()
        {
            
        }
        public DbSet<Pelicula> peliculas { get; set; }
        public DbSet<Genero> generos { get; set; }
        public DbSet<GeneroPelicula> generoPeliculas { get; set; }
        public DbSet<Rent> rents { get; set; }
        public DbSet<Rol> rols { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Sale> sales { get; set; }
    }
}
