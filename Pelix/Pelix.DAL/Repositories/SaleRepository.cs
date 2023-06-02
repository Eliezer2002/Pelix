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
    public class SaleRepository : ISaleRepository
    {
        private readonly PelixContext context;
        private readonly ILogger<SaleRepository> logger;

        public SaleRepository(PelixContext context, ILogger<SaleRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }
        public List<SaleModel> GetAll()
        {
            var Sales = context.tVentaPeliculas.Select(cd=> new SaleModel 
            {
                cod_pelicula=cd.cod_pelicula,
                cod_usuario=cd.cod_usuario,
                fecha=cd.fecha,
                precio=cd.precio,
                Id=cd.Id
            }).ToList();
            return Sales;
        }

        public Sale GetbyId(int Id)
        {
            return context.tVentaPeliculas.Find(Id);
        }

        public void Remove(Sale sale)
        {
            try
            {
                Sale saleRemove = this.GetbyId(sale.Id);
                context.tVentaPeliculas.Remove(saleRemove);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Removiendo Un Sale {ex.Message} ", ex.ToString());
            }
        }

        public void Save(Sale sale)
        {
            try
            {
                Sale saleAdd = new Sale() 
                {
                    cod_pelicula = sale.cod_pelicula,
                    cod_usuario = sale.cod_usuario,
                    fecha=sale.fecha,
                    precio=sale.precio,
                    Id=sale.Id
                };
                context.tVentaPeliculas.Add(saleAdd);
                context.SaveChanges();


            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Añadiendo Un Sale {ex.Message} ", ex.ToString());
            }
        }

        public void Update(Sale sale)
        {
            try
            {
                Sale saleUpdate = this.GetbyId(sale.Id);
                saleUpdate.precio = sale.precio;
                saleUpdate.cod_usuario= sale.cod_usuario;
                saleUpdate.fecha = sale.fecha;
                saleUpdate.cod_pelicula= sale.cod_pelicula;
                context.tVentaPeliculas.Update(saleUpdate);
                context.SaveChanges();
            }
            catch (System.Exception ex)
            {
                logger.LogError($"Error Actualizando Un Sale {ex.Message} ", ex.ToString());
            }
        }
    }
}
