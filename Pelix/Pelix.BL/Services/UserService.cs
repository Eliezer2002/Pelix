
using Microsoft.Extensions.Logging;
using Pelix.BL.Contract;
using Pelix.BL.Core;
using Pelix.BL.Dtos.User;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using System.Linq;

namespace Pelix.BL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly ILogger logger;

        public UserService(IUserRepository userRepository, ILogger<UserService> logger)
        {
            this.userRepository = userRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var users = userRepository.GetAll().ToList();
                result.Success = true;
                result.Data = users;
            }
            catch (System.Exception ex)
            {
                result.Success = false;
                result.Message = "Error Obteniendo Los Users";
                logger.LogError($"{ex.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var users = userRepository.GetbyId(id);
                result.Success = true;
                result.Data = users;
            }
            catch (System.Exception ex)
            {
                result.Success = false;
                result.Message = "Error Obteniendo el User";
                logger.LogError($"{ex.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveUser(UserRemoveDto userRemoveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                User userRemove = userRepository.GetbyId(userRemoveDto.cod_usuario);
                userRepository.Remove(userRemove);
                result.Success = true;
                result.Message = "El user Fue removido Exitosamente !!";
            }
            catch (System.Exception ex)
            {
                result.Success = false;
                result.Message = "Error Removiendo el User";
                logger.LogError($"{ex.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveUser(UserSaveDto userSaveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                User userSave = new User()
                {
                    cod_rol = userSaveDto.cod_rol,
                    nro_doc = userSaveDto.nro_doc,
                    sn_activo = userSaveDto.sn_activo,
                    txt_apellido = userSaveDto.txt_apellido,
                    txt_nombre = userSaveDto.txt_nombre,
                    txt_user = userSaveDto.txt_user,
                    txt_password = userSaveDto.txt_password
                };
                userRepository.Save(userSave);
                result.Success = true;
                result.Message = "El user Fue Agregado Exitosamente !!";
            }
            catch (System.Exception ex)
            {
                result.Success = false;
                result.Message = "Error Agregando el User";
                logger.LogError($"{ex.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateUser(UserUpdateDto userUpdateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                User userUpdate = userRepository.GetbyId(userUpdateDto.cod_usuario);
                userUpdate.txt_user = userUpdateDto.txt_user;
                userUpdate.txt_nombre = userUpdateDto.txt_nombre;
                userUpdate.txt_apellido = userUpdateDto.txt_apellido;
                userUpdate.txt_password = userUpdateDto.txt_password;
                userRepository.Update(userUpdate);
                result.Success = true;
                result.Message = "El user Fue Actualizado Exitosamente !!";
            }
            catch (System.Exception ex)
            {
                result.Success = false;
                result.Message = "Error Actualizando el User";
                logger.LogError($"{ex.Message}", ex.ToString());
            }
            return result;
        }
    }
}
