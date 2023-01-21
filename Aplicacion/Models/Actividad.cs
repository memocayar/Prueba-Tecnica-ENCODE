using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.Models
{
    public class Actividad
    {
        public Guid ActividadId { get; set; }

        public Guid UsuarioId { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string Descripcion { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}