using Pelix.DAL.Entities;
using Pelix.DAL.Models;
using System.Collections.Generic;

namespace Pelix.DAL.Interfaces
{
    public interface ISaleRepository
    {
        void Save(Sale sale);
        void Update(Sale sale);
        List<SaleModel> GetAll();
        Sale GetbyId(int Id);
        void Remove(Sale sale);
    }
}
