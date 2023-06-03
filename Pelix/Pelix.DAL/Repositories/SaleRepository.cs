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
        public override void Save(Sale entity)
        {
            base.Save(entity);
            base.SaveChanges();
        }
        public override void Remove(Sale entity)
        {
            base.Remove(entity);
            base.SaveChanges();
        }
        public override void Update(Sale entity)
        {
            base.Update(entity);
            base.SaveChanges();
        }
    }
}
