using Pelix.DAL.Entities;
using Pelix.DAL.Interfaces;
using Pelix.DAL.Models;
using System;
using System.Collections.Generic;

namespace Pelix.DAL.Repositories
{
    public class GeneroPeliculaRepository : IGeneroPeliculaRepository
    {
        public List<GeneroPeliculaModel> GetAll()
        {
            return new List<GeneroPeliculaModel>() 
            {
                new GeneroPeliculaModel 
                {
                    cod_genero=1,
                    cod_pelicula=1
                }
            };
        }

        public GeneroPelicula GetbyId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remove(GeneroPelicula generoPelicula)
        {
            throw new NotImplementedException();
        }

        public void Save(GeneroPelicula generoPelicula)
        {
            throw new NotImplementedException();
        }

        public void Update(GeneroPelicula generoPelicula)
        {
            throw new NotImplementedException();
        }
    }
}
