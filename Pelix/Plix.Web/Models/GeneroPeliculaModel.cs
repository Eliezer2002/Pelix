using System.ComponentModel.DataAnnotations;
using Pelix.Web.Models.ClasesBases;

namespace Pelix.Web.Models
{
    public class GeneroPeliculaModel : GeneroBase
    {
        [Key]
        public int cod_pelicula { get; set; }


    }
}
