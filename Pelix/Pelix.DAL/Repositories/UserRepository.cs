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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        private readonly PelixContext context;
        private readonly ILogger<UserRepository> logger;

        public UserRepository(PelixContext context, ILogger<UserRepository> logger) : base(context)
        {
            this.context = context;
            this.logger = logger;
        }
    }
}

