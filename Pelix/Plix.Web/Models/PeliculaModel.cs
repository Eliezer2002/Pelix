using System.ComponentModel.DataAnnotations;
using Pelix.Web.Models.ClasesBases;

namespace Pelix.Web.Models
{
    public class PeliculaModel : Cod_peliculaBase
    {
        public string? txt_desc { get; set; }
        public int? cant_disponibles_alquiler { get; set; }
        public int? cant_disponibles_venta { get; set; }
        public decimal? precio_alquiler { get; set; }
        public decimal? precio_venta { get; set; }
    }
}
