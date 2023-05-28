
using Microsoft.EntityFrameworkCore;
using Pelix.DAL.Context;
using Pelix.DAL.Core;
using System;

namespace Pelix.DAL.Dbfactory
{
    public class Dbfactory : IDbfactory, IDisposable
    {
        private readonly PelixContext _pelixContext;

        public Dbfactory(PelixContext pelixContext) => this._pelixContext = pelixContext;
        public DbContext GetDbfactory => this._pelixContext;
        private bool _isdisposed;
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing) 
        {
            if (!this._isdisposed) 
            { 
                if (_pelixContext != null) 
                {
                    _pelixContext.Dispose();
                }
            }
            this._isdisposed = true;
        }
    }
}
