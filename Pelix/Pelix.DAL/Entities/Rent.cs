using System.ComponentModel.DataAnnotations;
using Pelix.DAL.Core;

namespace Pelix.DAL.Entities
{
    public class Rent : ModeloBase
    {
        [Key]
        public int Id { get; set; }
        public int cod_usuario { get; set; }
        public byte devuelta { get; set; }
        public System.DateTime? fecha_devolucion { get; set; }
        public int? cod_usuario_devolucion { get; set; }
    }
}
