
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Pelix.DAL.Context;
using Pelix.DAL.Entities;
using Pelix.DAL.Exception;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pelix.DAL.Repositories
{
    public class PeliculaRepository : IPeliculaRepository
    {
        private readonly PelixContext context;
        private readonly ILogger logger;

        public PeliculaRepository(PelixContext context, ILogger<PeliculaRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public List<PeliculaModel> GetAll()
        {
            var peliculas = context.tPeliculas.Select(cd => new PeliculaModel()
            {
                txt_desc = cd.txt_desc,
                cant_disponibles_alquiler = cd.cant_disponibles_alquiler,
                cant_disponibles_venta = cd.cant_disponibles_venta,
                cod_pelicula = cd.cod_pelicula,
                precio_alquiler = cd.precio_alquiler,
                precio_venta = cd.precio_venta
            }).ToList();
            return peliculas;
        }

        public Pelicula GetbyId(int Id)
        {
            return context.tPeliculas.Find(Id);
        }

        public void Remove(Pelicula pelicula)
        {
            try
            {
                Pelicula peliculaRemove = this.GetbyId(pelicula.cod_pelicula);
                context.tPeliculas.Remove(peliculaRemove);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Ocurrio Un Error Removiendo La Pelicula { ex.Message }", ex.ToString());
            }  
        }

        public void Save(Pelicula pelicula)
        {
            try
            {
                //if (context.peliculas.Any(cd => cd.cod_pelicula == pelicula.cod_pelicula))
                //{
                //    throw new PeliculaException("La Pelicula Ya Existe!");
                //}
                Pelicula peliculaSave = new Pelicula() 
                {
                    cant_disponibles_alquiler = pelicula.cant_disponibles_alquiler,
                    cant_disponibles_venta = pelicula.cant_disponibles_venta,
                    precio_alquiler = pelicula.precio_alquiler,
                    txt_desc = pelicula.txt_desc,
                    precio_venta = pelicula.precio_venta
                };
                context.tPeliculas.Add(peliculaSave);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($" Ocurrio un error {ex.Message}", ex.ToString());
            }
        }

        public void Update(Pelicula pelicula)
        {
            try
            {
                Pelicula peliculaUpdate = this.GetbyId(pelicula.cod_pelicula);
                peliculaUpdate.precio_alquiler = pelicula.precio_alquiler;
                peliculaUpdate.precio_venta = pelicula.precio_venta;
                peliculaUpdate.cant_disponibles_venta = pelicula.cant_disponibles_venta;
                peliculaUpdate.cant_disponibles_alquiler = pelicula.cant_disponibles_alquiler;
                context.tPeliculas.Update(peliculaUpdate);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Ocurrio Un Error Actualizando La Pelicula {ex.Message}", ex.ToString());
            }
        }
    }
}
