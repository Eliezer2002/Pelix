using Pelix.DAL.Entities;
using Pelix.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelix.DAL.Interfaces
{
    public interface IGeneroPeliculaRepository
    {
        void Save(GeneroPelicula generoPelicula);
        void Update(GeneroPelicula generoPelicula);
        List<GeneroPeliculaModel> GetAll();
        GeneroPelicula GetbyId(int Id);
        void Remove(GeneroPelicula generoPelicula);
    }
}
