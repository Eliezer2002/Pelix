using System;
using System.Collections.Generic;
using System.Text;

namespace Pelix.BL.Dtos.Rent
{
    public class RentUpdateDto
    {
        public int Id { get; set; }
        public int cod_usuario { get; set; }
        public int cod_pelicula { get; set; }
        public bool devuelta { get; set; }
        public System.DateTime? fecha_devolucion { get; set; }
        public int? cod_usuario_devolucion { get; set; }
        public decimal precio { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
