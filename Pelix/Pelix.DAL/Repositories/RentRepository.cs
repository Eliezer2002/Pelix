using Pelix.DAL.Entities;
using Pelix.DAL.Models;
using Pelix.DAL.Interfaces;
using System;
using System.Collections.Generic;
using Pelix.DAL.Context;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Pelix.DAL.Repositories
{
    public class RentRepository : RepositoryBase<Rent>, IRentRepository 
    {
        private readonly PelixContext context;
        private readonly ILogger logger;

        public RentRepository(PelixContext context, ILogger<RentRepository> logger) : base (context)
        {
            this.context = context;
            this.logger = logger;
        }
    }
}
