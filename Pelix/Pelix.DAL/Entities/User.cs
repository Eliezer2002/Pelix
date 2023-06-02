using System.ComponentModel.DataAnnotations;
using Pelix.DAL.Core;

namespace Pelix.DAL.Entities
{
    public class User : ModeloBase2
    {
        [Key]
        public int cod_usuario { get; set; }
        public int cod_rol { get; set; }
        public string? txt_user { get; set; }
        public string? txt_password { get; set; }
        public string? txt_nombre { get; set; }
        public string? txt_apellido { get; set; }
        public string? nro_doc { get; set; }

    }
}
