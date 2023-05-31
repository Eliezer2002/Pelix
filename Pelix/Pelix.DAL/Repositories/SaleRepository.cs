using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System;
using System.Collections.Generic;

namespace Pelix.DAL.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        public List<SaleModel> GetAll()
        {
            return new List<SaleModel> ()
            { 
                new SaleModel()
                {
                    Id = 1,
                    cod_pelicula=1,
                    cod_usuario=1,
                    fecha=System.DateTime.Now,
                    precio=10
                } 
            };
        }

        public Sale GetbyId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void Save(Sale sale)
        {
            throw new NotImplementedException();
        }

        public void Update(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
