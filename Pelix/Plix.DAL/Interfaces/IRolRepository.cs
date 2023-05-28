using Pelix.DAL.Entities;
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface IRolRepository
    {
        void Save(Rol rol);
        void Update(Rol rol);
        List<Rol> GetAll();
        Rol GetbyId(int Id);
        void Remove(Rol rol);
    }
}
