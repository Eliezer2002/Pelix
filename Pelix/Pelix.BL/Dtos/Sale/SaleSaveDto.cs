
namespace Pelix.BL.Dtos.Sale
{
    public class SaleSaveDto
    {
        public int cod_usuario { get; set; }
        public int cod_pelicula { get; set; }
        public decimal precio { get; set; }
        public System.DateTime fecha { get; set; }
    }
}
