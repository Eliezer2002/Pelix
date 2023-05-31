using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System;
using System.Collections.Generic;

namespace Pelix.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<UserModel> GetAll()
        {
            return new List<UserModel>() 
            {
                new UserModel() 
                {
                    cod_rol=1,
                    cod_usuario=1,
                    nro_doc= "Eo",
                    sn_activo=1,
                    txt_apellido="Vargas",
                    txt_nombre= "Elie",
                    txt_password="123",
                    txt_user="1"
                }
            };
        }

        public User GetbyId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(User user)
        {
            throw new NotImplementedException();
        }

        public void Save(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
