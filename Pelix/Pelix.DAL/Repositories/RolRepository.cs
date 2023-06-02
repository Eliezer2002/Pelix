using Microsoft.Extensions.Logging;
using Pelix.DAL.Context;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pelix.DAL.Repositories
{
    public class RolRepository : RepositoryBase<Rol>, IRolRepository
    {
        private readonly PelixContext context;
        private readonly ILogger<RolRepository> logger;

        public RolRepository(PelixContext context, ILogger<RolRepository> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }
    }
}
