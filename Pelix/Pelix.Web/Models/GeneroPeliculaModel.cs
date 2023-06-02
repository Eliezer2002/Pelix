using System.ComponentModel.DataAnnotations;
using Pelix.Web.Models.ClasesBases;

namespace Pelix.Web.Models
{
    public class GeneroPeliculaModel 
    {
        [Key]
        public int cod_pelicula { get; set; }
        [Key]
        public int cod_genero { get; set; }

    }
}
