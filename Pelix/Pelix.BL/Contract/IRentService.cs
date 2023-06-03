
using Pelix.BL.Core;
using Pelix.BL.Dtos.Rent;

namespace Pelix.BL.Contract
{
    public interface IRentService : IBaseService
    {
        ServiceResult SaveRent(RentSaveDto rentSaveDto);
        ServiceResult RemoveRent(RentRemoveDto rentRemoveDto);
        ServiceResult UpdateRent(RentUpdateDto rentUpdateDto);
    }
}
