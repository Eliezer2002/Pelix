using Pelix.DAL.Entities;
using Pelix.DAL.Models;
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface IGeneroRepository
    {
        void Save(Genero genero);
        void Update(Genero genero);
        List<GenerosModel> GetAll();
        Genero GetbyId(int Id);
        void Remove(Genero genero);
    }
}
