using Pelix.BL.Core;
using Pelix.BL.Dtos.Pelicula;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelix.BL.Contract
{
    public interface IPeliculaService : IBaseService
    {
        ServiceResult SavePelicula(PeliculaSaveDto peliculaSaveDto);
        ServiceResult UpdatePelicula(PeliculaUpdateDto peliculaUpdateDto);
        ServiceResult RemovePelicula(PeliculaRemoveDto peliculaRemoveDto);
    }
}
