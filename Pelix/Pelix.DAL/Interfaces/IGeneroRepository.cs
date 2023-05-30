using Pelix.DAL.Entities;
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface IGeneroRepository
    {
        void Save(Genero genero);
        void Update(Genero genero);
        List<Genero> GetAll();
        Genero GetbyId(int Id);
        void Remove(Genero genero);
    }
}
