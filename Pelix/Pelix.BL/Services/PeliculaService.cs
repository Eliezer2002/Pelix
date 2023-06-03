
using Microsoft.Extensions.Logging;
using Pelix.BL.Contract;
using Pelix.BL.Core;
using Pelix.BL.Dtos.Pelicula;
using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using System.Linq;

namespace Pelix.BL.Services
{
    public class PeliculaService : IPeliculaService
    {
        private readonly IPeliculaRepository peliculaRepository;
        private readonly ILogger<PeliculaService> logger;

        public PeliculaService(IPeliculaRepository peliculaRepository, ILogger<PeliculaService> logger)
        {
            this.peliculaRepository = peliculaRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var Peliculas = peliculaRepository.GetAll().ToList();
                result.Data = Peliculas;
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Obteniendo Las Peliculas";
                result.Success = false;
                logger.LogError($"{result.Message}",ex.ToString());

            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var pelicula = peliculaRepository.GetbyId(id);
                result.Data=pelicula;
                result.Success=true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Obteniendo La Peliculas";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemovePelicula(PeliculaRemoveDto peliculaRemoveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Pelicula peliculaRemove = this.peliculaRepository.GetbyId(peliculaRemoveDto.cod_pelicula);
                peliculaRepository.Remove(peliculaRemove);
                result.Message = "La Pelicula Ha Sido Removida Correctamente!!";
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Removiendo La Pelicula";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult SavePelicula(PeliculaSaveDto peliculaSaveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Pelicula pelicula = new Pelicula() 
                {
                    cant_disponibles_alquiler = peliculaSaveDto.cant_disponibles_alquiler,
                    cant_disponibles_venta = peliculaSaveDto.cant_disponibles_venta,
                    precio_alquiler = peliculaSaveDto.precio_alquiler,
                    precio_venta = peliculaSaveDto.precio_venta,
                    txt_desc = peliculaSaveDto.txt_desc
                };
                peliculaRepository.Save(pelicula);
                result.Message = "La Pelicula Ha Sido Guardada Correctamente!!";
                result.Success = true;
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Guardando La Pelicula";
                result.Success = false;
                logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;

        }

        public ServiceResult UpdatePelicula(PeliculaUpdateDto peliculaUpdateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Pelicula peliculaUpdate = this.peliculaRepository.GetbyId(peliculaUpdateDto.cod_pelicula);
                peliculaUpdate.txt_desc=peliculaUpdateDto.txt_desc;
                peliculaUpdate.precio_venta=peliculaUpdate.precio_venta;
                peliculaUpdate.cant_disponibles_venta = peliculaUpdateDto.cant_disponibles_venta;
                peliculaUpdate.cant_disponibles_alquiler = peliculaUpdateDto.cant_disponibles_alquiler;
                peliculaUpdate.precio_alquiler = peliculaUpdateDto.precio_alquiler;
                peliculaRepository.Update(peliculaUpdate);
                result.Success = true;
                result.Message = "La Pelicula Ha Sido Actualizada Correctamente!!";
            }
            catch (System.Exception ex)
            {
                result.Message = "Ocurrio Un Error Removiendo La Pelicula";
                result.Success = false;
                logger.LogError($"{ex.Message}", ex.ToString());
            }
            return result;
        }
    }
}
