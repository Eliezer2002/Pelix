using Pelix.DAL.Entities;
using Pelix.DAL.Models;
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface IRolRepository
    {
        void Save(Rol rol);
        void Update(Rol rol);
        List<RolModel> GetAll();
        Rol GetbyId(int Id);
        void Remove(Rol rol);
    }
}
