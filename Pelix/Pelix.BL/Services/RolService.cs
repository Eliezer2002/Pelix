
using Microsoft.Extensions.Logging;
using Pelix.BL.Contract;
using Pelix.BL.Core;
using Pelix.BL.Dtos.Rol;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using System.Linq;

namespace Pelix.BL.Services
{
    public class RolService : IRolService
    {
        private readonly IRolRepository rolRepository;
        private readonly ILogger logger;

        public RolService(IRolRepository rolRepository, ILogger<RolService> logger)
        {
            this.rolRepository = rolRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var Rols = rolRepository.GetAll().ToList(); 
                result.Data = Rols;
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un error Obteniendo Los Roles";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var Rol = rolRepository.GetbyId(id);
                result.Data = Rol;
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un error Obteniendo el Rol";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveRol(RolRemoveDto rolRemoveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Rol rol = rolRepository.GetbyId(rolRemoveDto.cod_rol);
                rolRepository.Remove(rol);
                rol.sn_activo = -1;
                result.Message = "El Rol Fue Desactivado Exitosamente !!";
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un error Desativando el Rol";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveRol(RolSaveDto rolSaveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Rol rol = new Rol() 
                {
                    sn_activo = 1,
                    txt_desc = rolSaveDto.txt_desc
                };
                rolRepository.Save(rol);
                result.Message = "El Rol Fue Agregado Exitosamente !!";
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un error Guardando el Rol";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateRol(RolUpdateDto rolUpdateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Rol rol = rolRepository.GetbyId(rolUpdateDto.cod_rol);
                rol.sn_activo = rolUpdateDto.sn_activo;
                rol.txt_desc = rolUpdateDto.txt_desc;
                rolRepository.Update(rol);
                result.Message = "El Rol Fue Actualizado Exitosamente !!";
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un error Actualizando el Rol";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }
    }
}
