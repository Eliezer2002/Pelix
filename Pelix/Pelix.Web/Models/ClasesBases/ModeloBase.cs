using System.ComponentModel.DataAnnotations;

namespace Pelix.Web.Models.ClasesBases
{
    public class ModeloBase : Cod_peliculaBase
    {
        public decimal precio { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
