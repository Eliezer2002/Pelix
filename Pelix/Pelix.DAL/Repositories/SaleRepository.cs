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
    public class SaleRepository : RepositoryBase<Sale>, ISaleRepository
    {
        private readonly PelixContext context;
        private readonly ILogger<SaleRepository> logger;

        public SaleRepository(PelixContext context, ILogger<SaleRepository> logger): base(context)
        {
            this.context = context;
            this.logger = logger;
        }
    }
}
