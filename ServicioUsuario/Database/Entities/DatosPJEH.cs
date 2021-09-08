using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ServicioUsuario.Database.Entities
{
    public class DatosPJEH
    {
        [Key]
        public int IDSolicitud { get; set; }
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
}
