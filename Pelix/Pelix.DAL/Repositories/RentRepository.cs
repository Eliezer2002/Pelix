using Pelix.DAL.Entities;
using Pelix.DAL.Models;
using Pelix.DAL.Interfaces;
using System;
using System.Collections.Generic;


namespace Pelix.DAL.Repositories
{
    public class RentRepository : IRentRepository
    {
        public List<RentModel> GetAll()
        {
            return new List<RentModel>()
            {
                new RentModel()
                {
                    Id = 1,
                    cod_usuario = 1,
                    cod_usuario_devolucion = 1,
                    devuelta = 1,
                    fecha_devolucion = System.DateTime.Now

                }
         
            };
        }

        public Rent GetbyId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Rent rent)
        {
            throw new NotImplementedException();
        }

        public void Save(Rent rent)
        {
            throw new NotImplementedException();
        }

        public void Update(Rent rent)
        {
            throw new NotImplementedException();
        }
    }
}
