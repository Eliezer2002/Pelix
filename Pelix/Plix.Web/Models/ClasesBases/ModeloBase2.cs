using System.ComponentModel.DataAnnotations;

namespace Pelix.Web.Models.ClasesBases
{
    public class ModeloBase2
    {
        [Key]
        public int cod_rol { get; set; }
        public int? sn_activo { get; set; }
    }
}
