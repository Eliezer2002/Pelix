using System.ComponentModel.DataAnnotations;
using Pelix.DAL.Core;

namespace Pelix.DAL.Entities
{
    public class Rol : ModeloBase2
    {
        [Key]
        public int cod_rol { get; set; }
        public string? txt_desc { get; set; }
    }
}
