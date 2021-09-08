using System.ComponentModel.DataAnnotations;

namespace ServicioPJ.Database.Entities
{
    public class MicroPJ
    {
        [Key]
        public int IdSolicitud { get; set; }
        public string Estado { get; set; }
        public string NoOficioSolicitud { get; set; }
        public string NUC { get; set; }
        public string TipoAudiencia { get; set; }
        public string FechaAudiencia { get; set; }
        public string SalaAsignada { get; set; }
        public string JuzgadoAsignado { get; set; }
        public string AsuntoRelacionado { get; set; }
    }
}
