
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Pelix.DAL.Context;
using Pelix.DAL.Entities;
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
    }
}
