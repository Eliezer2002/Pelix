
using Microsoft.Extensions.Logging;
using Pelix.BL.Contract;
using Pelix.BL.Core;
using Pelix.BL.Dtos.Sale;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;

namespace Pelix.BL.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository saleRepository;
        private readonly ILogger logger;

        public SaleService(ISaleRepository saleRepository, ILogger<SaleService> logger)
        {
            this.saleRepository = saleRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var sales = saleRepository.GetAll();
                result.Success = true;
                result.Data = sales;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Obteniendo Los Sale";
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
                var sale = saleRepository.GetbyId(id);
                result.Success = true;
                result.Data = sale;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Obteniendo el Sale";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveSale(SaleRemoveDto saleRemoveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Sale saleRemove = saleRepository.GetbyId(saleRemoveDto.Id);
                saleRepository.Remove(saleRemove);
                result.Success = true;
                result.Message = "El Sale Fue Removido Correctamente";
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Removiendo el Sale";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveSale(SaleSaveDto saleSaveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Sale saleSave = new Sale()
                {
                    cod_pelicula = saleSaveDto.cod_pelicula,
                    cod_usuario = saleSaveDto.cod_usuario,
                    fecha = saleSaveDto.fecha,
                    precio = saleSaveDto.precio
                };
                saleRepository.Save(saleSave);
                result.Success = true;
                result.Message = "El Sale Fue Agregado Correctamente";
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Guardando el Sale";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateSale(SaleUpdateDto saleUpdateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Sale saleUpdate = saleRepository.GetbyId(saleUpdateDto.Id);
                saleUpdate.precio= saleUpdateDto.precio;
                saleUpdate.fecha = saleUpdateDto.fecha;
                saleRepository.Update(saleUpdate);
                result.Success = true;
                result.Message = "El Sale Fue Actualizado Correctamente";
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Actualizando el Sale";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }
    } 
}
