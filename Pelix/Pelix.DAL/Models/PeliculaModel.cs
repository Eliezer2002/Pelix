using Pelix.DAL.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelix.DAL.Models
{
    public class PeliculaModel : Cod_peliculaBase
    {
        public string? txt_desc { get; set; }
        public int? cant_disponibles_alquiler { get; set; }
        public int? cant_disponibles_venta { get; set; }
        public double? precio_alquiler { get; set; }
        public double? precio_venta { get; set; }
    }
}
