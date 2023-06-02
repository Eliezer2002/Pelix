using System.ComponentModel.DataAnnotations;
using Pelix.Web.Models.ClasesBases;

namespace Pelix.Web.Models
{
    public class SaleModel : ModeloBase
    {
        [Key]
        public int Id { get; set; }
        public int cod_pelicula { get; set; }
        public int cod_usuario { get; set; }
    }
}
