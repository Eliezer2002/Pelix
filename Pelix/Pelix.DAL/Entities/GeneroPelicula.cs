using Pelix.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Pelix.DAL.Entities
{
    public class GeneroPelicula : GeneroBase
    {
        [Key]
        public int cod_pelicula { get; set; }


    }
}
