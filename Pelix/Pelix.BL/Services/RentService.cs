using Microsoft.Extensions.Logging;
using Pelix.BL.Contract;
using Pelix.BL.Core;
using Pelix.BL.Dtos.Rent;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pelix.BL.Services
{
    public class RentService : IRentService
    {
        private readonly IRentRepository rentRepository;
        private readonly ILogger logger;

        public RentService(IRentRepository rentRepository, ILogger<RentService> logger)
        {
            this.rentRepository = rentRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var rents = rentRepository.GetAll().ToList();
                result.Success = true;
                result.Data = rents;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error Obteniendo los Rents";
                result.Success= false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result= new ServiceResult();
            try
            {
                var rent = rentRepository.GetbyId(id);
                result.Success = true;
                result.Data = rent;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error Obteniendo el Rent";
                result.Success= false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveRent(RentRemoveDto rentRemoveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Rent rentUpdate = rentRepository.GetbyId(rentRemoveDto.Id);
                rentRepository.Remove(rentUpdate);
                result.Message = "El Rent Fue Removido Exitosamente !!";
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error Removiendo el Rent";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveRent(RentSaveDto rentSaveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Rent rentSave = new Rent() 
                { 
                    devuelta = rentSaveDto.devuelta,
                    cod_pelicula = rentSaveDto.cod_pelicula,
                    cod_usuario = rentSaveDto.cod_usuario,
                    cod_usuario_devolucion = rentSaveDto.cod_usuario_devolucion,
                    fecha = rentSaveDto.fecha,
                    fecha_devolucion = rentSaveDto.fecha_devolucion,
                    precio = rentSaveDto.precio
                };
                rentRepository.Save(rentSave);
                result.Message = "El Rent Fue Agregado Exitosamente !!";
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error Guardando el Rent";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateRent(RentUpdateDto rentUpdateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Rent rentUpdate = rentRepository.GetbyId(rentUpdateDto.Id);
                rentUpdate.precio = rentUpdateDto.precio;
                rentUpdate.devuelta = rentUpdateDto.devuelta;
                rentUpdate.cod_usuario_devolucion = rentUpdateDto.cod_usuario_devolucion;
                rentUpdate.cod_usuario = rentUpdateDto.cod_usuario;
                rentRepository.Update(rentUpdate);
                result.Message = "El Rent Fue Actualizado Exitosamente !!";
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error Actualizando el Rent";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }
    }
}
