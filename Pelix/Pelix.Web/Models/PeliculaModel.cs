using System.ComponentModel.DataAnnotations;
using Pelix.Web.Exception;
using Pelix.Web.Models.ClasesBases;

namespace Pelix.Web.Models
{
    public class PeliculaModel : Cod_peliculaBase
    {
        private string _txt_desc;
        public string? txt_desc { get { return _txt_desc; } 
            set 
            {
                if (value.Length > 500)
                {
                    throw new PeliculaException("La Longitud Sobrepasa Los 500");
                }
                else 
                {
                    _txt_desc = value;
                }
           
            } 
        }
        public int? cant_disponibles_alquiler { get; set; }
        public int? cant_disponibles_venta { get; set; }
        public decimal? precio_alquiler { get; set; }
        public decimal? precio_venta { get; set; }
    }
}
