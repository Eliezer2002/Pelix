using System.ComponentModel.DataAnnotations;
using Pelix.DAL.Core;

namespace Pelix.DAL.Entities
{
    public class Genero : GeneroBase
    {
        public string? txt_desc { get; set; }
    }
}
