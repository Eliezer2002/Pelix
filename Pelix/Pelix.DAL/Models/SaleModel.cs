
using Pelix.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace Pelix.DAL.Models
{
    public class SaleModel : ModeloBase
    {
        [Key]
        public int Id { get; set; }
        public int cod_usuario { get; set; }
    }
}
