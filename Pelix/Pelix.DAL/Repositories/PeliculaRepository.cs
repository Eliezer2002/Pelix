
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Pelix.DAL.Context;
using Pelix.DAL.Entities;
using Pelix.DAL.Exception;
using Pelix.DAL.Interfaces;


namespace Pelix.DAL.Repositories
{
    public class PeliculaRepository : RepositoryBase<Pelicula>, IPeliculaRepository
    {
        private readonly PelixContext context;
        private readonly ILogger logger;

        public PeliculaRepository(PelixContext context, ILogger<PeliculaRepository> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }
        public override void Save(Pelicula entity)
        {
            //Logica para campos que no pueden ser nulos
            //if (string.IsNullOrEmpty(entity.CAMPO)) 
            //{
            //    throw new PeliculaException("El campo es Requerido");
            //}
            base.Save(entity);
            base.SaveChanges();
        }
        public override void Remove(Pelicula entity)
        {
            base.Remove(entity);
            base.SaveChanges();
        }
        public override void Update(Pelicula entity)
        {
            base.Update(entity);
            base.SaveChanges();
        }
    }
}
