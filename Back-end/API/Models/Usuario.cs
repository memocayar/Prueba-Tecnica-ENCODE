using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.models;

[Table("usuarios")]
public class Usuario
{
    [Key]
    [Column("id_usuario")]
    public Guid UsuarioId { get; set; }

    [Required]
    [Column("nombre")]
    public string Nombre { get; set; }

    [Required]
    [Column("apellido")]
    public string Apellido { get; set; }

    [Required]
    [Column("correo_electronico")]
    public string CorreoElectronico { get; set; }

    [Required]
    [Column("fecha_nacimiento")]
    public DateTime FechaNacimiento { get; set; }

    [Column("telefono")]
    public int Telefono { get; set; }

    [Required]
    [Column("pais")]
    public string Pais { get; set; }

    [Required]
    [Column("contacto")]
    public bool Contacto { get; set; }

    public virtual ICollection<Actividad> Actividades { get; set; }
}
