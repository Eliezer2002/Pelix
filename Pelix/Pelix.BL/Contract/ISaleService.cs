using Pelix.BL.Core;
using Pelix.BL.Dtos.Sale;

namespace Pelix.BL.Contract
{
    public interface ISaleService : IBaseService
    {
        ServiceResult SaveSale(SaleSaveDto saleSaveDto);
        ServiceResult UpdateSale(SaleUpdateDto saleUpdateDto);
        ServiceResult RemoveSale(SaleRemoveDto saleRemoveDto);
    }
}
