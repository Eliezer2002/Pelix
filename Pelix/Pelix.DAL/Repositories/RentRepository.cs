using Pelix.DAL.Entities;
using Pelix.DAL.Models;
using Pelix.DAL.Interfaces;
using System;
using System.Collections.Generic;
using Pelix.DAL.Context;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Pelix.DAL.Repositories
{
    public class RentRepository : IRentRepository
    {
        private readonly PelixContext context;
        private readonly ILogger logger;

        public RentRepository(PelixContext context, ILogger<RentRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public List<RentModel> GetAll()
        {
            var rents = context.tAlquilerPeliculas.Select(cd=> new RentModel() 
            { 
                cod_pelicula = cd.cod_pelicula,
                cod_usuario = cd.cod_usuario,
                cod_usuario_devolucion = cd.cod_usuario_devolucion,
                devuelta = cd.devuelta,
                fecha_devolucion = cd.fecha_devolucion
            }).ToList();
            return rents;
        }

        public Rent GetbyId(int Id)
        {
            return context.tAlquilerPeliculas.Find(Id);
        }

        public void Remove(Rent rent)
        {
            try
            {
                Rent RentRemove = this.GetbyId(rent.Id);
                context.tAlquilerPeliculas.Remove(RentRemove);
                context.SaveChanges();

            }
            catch (System.Exception ex)
            {
                logger.LogError($"Ocurrio Un Error Removiendo el Rent {ex.Message}", ex.ToString());
            }
        }

        public void Save(Rent rent)
        {
            try
            {
                Rent rentSave = new Rent()
                {
                    precio = rent.precio,
                    cod_pelicula = rent.cod_pelicula,
                    cod_usuario = rent.cod_usuario,
                    devuelta = rent.devuelta,
                    cod_usuario_devolucion = rent.cod_usuario_devolucion,
                    fecha = rent.fecha,
                    fecha_devolucion = rent.fecha_devolucion,
                };
                context.Add(rentSave);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Guardando el Rent {ex.Message}", ex.ToString());
            }
        }

        public void Update(Rent rent)
        {
            try
            {
                Rent rentUpdate = this.GetbyId(rent.Id);
                rentUpdate.Id = rent.Id;
                rentUpdate.precio = rent.precio;
                rentUpdate.devuelta = rent.devuelta;
                rentUpdate.cod_pelicula= rent.cod_pelicula;
                rentUpdate.cod_usuario= rent.cod_usuario;
                rentUpdate.fecha = rent.fecha;
                rentUpdate.fecha_devolucion = rent.fecha_devolucion;
                context.tAlquilerPeliculas.Update(rentUpdate);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Actualizando el Rent {ex.Message }", ex.ToString());
            }
        }
    }
}
