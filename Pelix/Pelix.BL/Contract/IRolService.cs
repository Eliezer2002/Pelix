using Pelix.BL.Core;
using Pelix.BL.Dtos.Rol;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelix.BL.Contract
{
    public interface IRolService : IBaseService
    {
        ServiceResult SaveRol(RolSaveDto rolSaveDto);
        ServiceResult RemoveRol(RolRemoveDto rolRemoveDto);
        ServiceResult UpdateRol(RolUpdateDto rolUpdateDto);
    }
}
