using System.ComponentModel.DataAnnotations;

namespace Pelix.DAL.Core
{
    public abstract class ModeloBase
    {
        public decimal precio { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
