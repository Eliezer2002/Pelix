using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System;
using System.Collections.Generic;

namespace Pelix.DAL.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        public List<GenerosModel> GetAll()
        {
            return new List<GenerosModel>() {
            new GenerosModel()
            {
                txt_desc= "Cura",
                cod_genero=1
            }
            };
        }

        public Genero GetbyId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Genero genero)
        {
            throw new NotImplementedException();
        }

        public void Save(Genero genero)
        {
            throw new NotImplementedException();
        }

        public void Update(Genero genero)
        {
            throw new NotImplementedException();
        }
    }
}
