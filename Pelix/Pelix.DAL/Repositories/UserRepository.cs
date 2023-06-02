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
    public class UserRepository : IUserRepository
    {
        private readonly PelixContext context;
        private readonly ILogger<UserRepository> logger;

        public UserRepository(PelixContext context, ILogger<UserRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public List<UserModel> GetAll()
        {
            var users = context.tUsers.Select(cd => new UserModel()
            {
                cod_rol = cd.cod_rol,
                cod_usuario = cd.cod_usuario,
                nro_doc = cd.nro_doc,
                sn_activo = cd.sn_activo,
                txt_apellido = cd.txt_apellido,
                txt_nombre = cd.txt_nombre,
                txt_password = cd.txt_password,
                txt_user = cd.txt_user
            }).ToList();
            return users;
        }

        public User GetbyId(int Id)
        {
            return context.tUsers.Find(Id);
        }

        public void Remove(User user)
        {
            try
            {
                User userRemove = this.GetbyId(user.cod_usuario);
                context.tUsers.Remove(userRemove);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Removiendo el Usuario {ex.Message}", ex.ToString());
            }

        }

        public void Save(User user)
        {
            try
            {
                User userSave = new User()
                {
                    cod_usuario = user.cod_usuario,
                    cod_rol = user.cod_rol,
                    nro_doc = user.nro_doc,
                    txt_user = user.txt_user,
                    txt_nombre = user.txt_nombre,
                    txt_apellido = user.txt_apellido,
                    txt_password = user.txt_password
                };
                context.tUsers.Add(userSave);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Añadiendo el Usuario {ex.Message}", ex.ToString());
            }

        }

    public void Update(User user)
    {
        try
        {
            User userUpdate = this.GetbyId(user.cod_usuario);
            userUpdate.cod_usuario = user.cod_usuario;
            userUpdate.cod_rol = user.cod_rol;
            userUpdate.nro_doc = user.nro_doc;
            userUpdate.txt_user = user.txt_user;
            userUpdate.txt_nombre = user.txt_nombre;
            userUpdate.txt_apellido = user.txt_apellido;
            userUpdate.txt_password = user.txt_password;
            context.tUsers.Update(userUpdate);
            context.SaveChanges();
        }
        catch (System.Exception ex)
        {
            logger.LogError($"Error Actualizando el Usuario {ex.Message}", ex.ToString());
        }

    }
}
}
