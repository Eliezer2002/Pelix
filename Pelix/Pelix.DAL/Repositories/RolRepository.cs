using Pelix.DAL.Context;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System;
using System.Collections.Generic;

namespace Pelix.DAL.Repositories
{
    public class RolRepository : IRolRepository
    {
        public List<RolModel> GetAll()
        {
            return new List<RolModel>() 
            {
                new RolModel
                {
                    cod_rol=1,
                    sn_activo=1,
                    txt_desc= "PeliculaNueva"
                }
            };
        }

        public Rol GetbyId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Rol rol)
        {
            throw new NotImplementedException();
        }

        public void Save(Rol rol)
        {
            throw new NotImplementedException();
        }

        public void Update(Rol rol)
        {
            throw new NotImplementedException();
        }
    }
}
