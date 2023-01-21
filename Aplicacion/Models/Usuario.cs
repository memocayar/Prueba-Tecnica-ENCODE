using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.Models
{
    public class Usuario
    {
        public Guid UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string CorreoElectronico { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Telefono { get; set; }

        public string Pais { get; set; }

        public bool Contacto { get; set; }

        public virtual ICollection<Actividad> Actividades { get; set; }
    }
}