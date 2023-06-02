using System.ComponentModel.DataAnnotations;
using Pelix.Web.Models.ClasesBases;

namespace Pelix.Web.Models
{
    public class GenerosModel 
    {
        [Key]
        public int cod_genero { get; set; }
        public string? txt_desc { get; set; }
    }
}
