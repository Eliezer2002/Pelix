﻿
namespace Pelix.BL.Core
{
    public class BaseDto
    {
        public string? txt_desc { get; set; }
        public int? cant_disponibles_alquiler { get; set; }
        public int? cant_disponibles_venta { get; set; }
        public decimal? precio_alquiler { get; set; }
        public decimal? precio_venta { get; set; }
    }
}
