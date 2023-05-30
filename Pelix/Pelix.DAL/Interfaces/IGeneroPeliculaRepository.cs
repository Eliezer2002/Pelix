using Pelix.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelix.DAL.Interfaces
{
    public interface IGeneroPeliculaRepository
    {
        void Save(GeneroPelicula generoPelicula);
        void Update(GeneroPelicula generoPelicula);
        List<GeneroPelicula> GetAll();
        GeneroPelicula GetbyId(int Id);
        void Remove(GeneroPelicula generoPelicula);
    }
}
