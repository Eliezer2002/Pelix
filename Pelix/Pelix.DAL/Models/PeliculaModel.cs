using Pelix.DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pelix.DAL.Models
{
    public class PeliculaModel
    {
        [Key]
        public int cod_pelicula { get; set; }
        public string? txt_desc { get; set; }
        public int? cant_disponibles_alquiler { get; set; }
        public int? cant_disponibles_venta { get; set; }
        public decimal? precio_alquiler { get; set; }
        public decimal? precio_venta { get; set; }
    }
}
