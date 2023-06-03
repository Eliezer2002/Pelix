
using Pelix.BL.Core;
using Pelix.BL.Dtos.User;

namespace Pelix.BL.Contract
{
    public interface IUserService : IBaseService
    {
        ServiceResult SaveUser(UserSaveDto userSaveDto);
        ServiceResult RemoveUser(UserRemoveDto userRemoveDto);
        ServiceResult UpdateUser(UserUpdateDto userUpdateDto);
    }
}
