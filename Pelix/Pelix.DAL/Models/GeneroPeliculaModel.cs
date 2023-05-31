using Pelix.DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pelix.DAL.Models
{
    public class GeneroPeliculaModel : GeneroBase
    {
        [Key]
        public int cod_pelicula { get; set; }
    }
}
