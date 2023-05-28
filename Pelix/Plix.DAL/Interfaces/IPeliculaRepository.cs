
using Pelix.DAL.Entities;
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface IPeliculaRepository
    {
        void Save(Pelicula pelicula);
        void Update(Pelicula pelicula);
        List<Pelicula> GetAll();
        Pelicula GetbyId(int Id);
        void Remove(Pelicula pelicula);
    }
}
