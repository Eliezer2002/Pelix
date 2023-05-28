using System.ComponentModel.DataAnnotations;

namespace Pelix.DAL.Core
{
    public class ModeloBase2
    {
        [Key]
        public int cod_rol { get; set; }
        public int? sn_activo { get; set; }
    }
}
