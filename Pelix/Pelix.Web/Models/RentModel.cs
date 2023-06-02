using System.ComponentModel.DataAnnotations;
using Pelix.Web.Models.ClasesBases;

namespace Pelix.Web.Models
{
    public class RentModel : ModeloBase
    {
        [Key]
        public int Id { get; set; }
        public int cod_pelicula { get; set; }
        public int cod_usuario { get; set; }
        public byte devuelta { get; set; }
        public System.DateTime? fecha_devolucion { get; set; }
        public int? cod_usuario_devolucion { get; set; }
    }
}
