using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.models;

[Table("actividad")]
public class Actividad
{
    [Key]
    [Column("id_actividad")]
    public Guid ActividadId { get; set; }

    [ForeignKey("Usuario")]
    public Guid UsuarioId { get; set; }

    [Column("create_date")]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime FechaCreacion { get; set; }

    [Column("actividad")]
    public string Descripcion { get; set; }

    public virtual Usuario Usuario { get; set; }
}