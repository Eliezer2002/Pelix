using Microsoft.EntityFrameworkCore;
using Pelix.DAL.Context;
using Pelix.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pelix.DAL.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly PelixContext context;
        private readonly DbSet<TEntity> myDbset;
        public RepositoryBase(PelixContext context)
        {
            this.context = context;
            this.myDbset = this.context.Set<TEntity>();
        }
        public virtual List<TEntity> GetAll()
        {
            return this.myDbset.ToList();
        }

        public virtual TEntity GetbyId(int id)
        {
            return this.myDbset.Find(id);
        }

        public virtual void Remove(TEntity entity)
        {
            this.myDbset.Remove(entity);
        }

        public virtual void Save(TEntity entity)
        {
            this.myDbset.Add(entity);
        }

        public virtual void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public virtual void Update(TEntity entity)
        {
            this.myDbset.Update(entity);
        }
    }
}
