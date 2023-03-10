using System;
using System.Collections.Generic;

namespace EncodeApp.Models;

public partial class Usuario
{
    public long IdUsuario { get; set; }

    public bool Alta { get; set; } = true;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }

    public string? Telefono { get; set; }

    public string Pais { get; set; } = null!;

    public bool Contacto { get; set; }

    public virtual ICollection<Actividad> Actividades { get; } = new List<Actividad>();
}
