
using System.ComponentModel.DataAnnotations;

namespace Pelix.DAL.Models
{
    public class RentModel
    {
        [Key]
        public int Id { get; set; }
        public int cod_usuario { get; set; }
        public byte devuelta { get; set; }
        public System.DateTime? fecha_devolucion { get; set; }
        public int? cod_usuario_devolucion { get; set; }
    }
}
