using Pelix.DAL.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Pelix.DAL.Models
{
    public class RolModel : ModeloBase2
    {
        [Key]
        public int cod_rol { get; set; }
        public string? txt_desc { get; set; }
    }
}
