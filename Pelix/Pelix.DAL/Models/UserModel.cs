
using Pelix.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Pelix.DAL.Models
{
    public class UserModel : ModeloBase2
    {
        [Key]
        public int cod_usuario { get; set; }
        public string? txt_user { get; set; }
        public string? txt_password { get; set; }
        public string? txt_nombre { get; set; }
        public string? txt_apellido { get; set; }
        public string? nro_doc { get; set; }
    }
}
