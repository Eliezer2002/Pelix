
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Pelix.DAL.Context;
using Pelix.DAL.Entities;
using Pelix.DAL.Exception;
using Pelix.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Pelix.DAL.Repositories
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly PelixContext context;
        private readonly ILogger logger;

        public PeliculaRepository( PelixContext context, ILogger<PeliculaRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public List<Pelicula> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Pelicula GetbyId(int Id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Pelicula pelicula)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Pelicula pelicula)
        {
            try
            {
                if (context.peliculas.Any(cd => cd.cod_pelicula == pelicula.cod_pelicula)) 
                {
                    throw new PeliculaException("La Pelicula Ya Existe!");
                }
                context.peliculas.Add(pelicula);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($" Ocurrio un error {ex.Message}", ex.ToString());
            }
        }

        public void Update(Pelicula pelicula)
        {
            throw new System.NotImplementedException();
        }
    }
}
