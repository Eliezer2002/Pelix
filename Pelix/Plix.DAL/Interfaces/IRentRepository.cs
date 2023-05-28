using Pelix.DAL.Entities;
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface IRentRepository
    {
        void Save(Rent rent);
        void Update(Rent rent);
        List<Rent> GetAll();
        Rent GetbyId(int Id);
        void Remove(Rent rent);
    }
}
