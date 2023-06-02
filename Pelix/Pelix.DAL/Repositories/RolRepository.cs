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
    public class RolRepository : IRolRepository
    {
        private readonly PelixContext context;
        private readonly ILogger<RolRepository> logger;

        public RolRepository(PelixContext context, ILogger<RolRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public List<RolModel> GetAll()
        {
            var rols = context.tRols.Select(cd => new RolModel 
            {
                txt_desc = cd.txt_desc,
                sn_activo = cd.sn_activo,
                cod_rol = cd.cod_rol
            }).ToList();
            return rols;
        }

        public Rol GetbyId(int Id)
        {
            return context.tRols.Find(Id);
        }

        public void Remove(Rol rol)
        {
            try
            {
                Rol Rol = this.GetbyId(rol.cod_rol);
                context.tRols.Remove(Rol);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Removiendo el Rol { ex.Message }", ex.ToString());
            }

        }

        public void Save(Rol rol)
        {
            try
            {
                Rol Rol = new Rol() 
                {
                    txt_desc = rol.txt_desc,
                    cod_rol=rol.cod_rol,
                    sn_activo= rol.sn_activo
                };
                context.tRols.Add(rol);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Añadiendo el Rol {ex.Message}", ex.ToString());
            }

        }

        public void Update(Rol rol)
        {
            try
            {
                Rol rolUpdate = this.GetbyId(rol.cod_rol);
                rolUpdate.txt_desc = rol.txt_desc;
                rolUpdate.cod_rol = rol.cod_rol;
                rolUpdate.sn_activo = rol.sn_activo;
                context.tRols.Update(rolUpdate);
                context.SaveChanges();

            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Actualizando el Rol {ex.Message}", ex.ToString());
            }

        }
    }
}
