using Aplicacion.Models;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion;

public class AplicacionContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Actividad> Actividad { get; set; }

    public AplicacionContext(DbContextOptions<AplicacionContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(usuario =>
        {
            usuario.ToTable("usuario");
            usuario.HasKey(p => p.UsuarioId);
            usuario.Property(p => p.UsuarioId).HasColumnName("id_usuario");
            usuario.Property(p => p.Nombre).IsRequired().HasColumnName("nombre");
            usuario.Property(p => p.Apellido).IsRequired().HasColumnName("apellido");
            usuario.Property(p => p.CorreoElectronico).IsRequired().HasColumnName("correo_electronico");
            usuario.Property(p => p.FechaNacimiento).IsRequired().HasColumnName("fecha_nacimiento");
            usuario.Property(p => p.Telefono).HasColumnName("telefono");
            usuario.Property(p => p.Pais).IsRequired().HasColumnName("pais");
            usuario.Property(p => p.Contacto).IsRequired().HasColumnName("contacto");
        });

        modelBuilder.Entity<Actividad>(actividad =>

        {
            actividad.ToTable("actividad");
            actividad.HasKey(p => p.ActividadId);
            actividad.Property(p => p.ActividadId).HasColumnName("id_actividad");
            actividad.HasOne(p => p.Usuario).WithMany(p => p.Actividades).HasForeignKey(p => p.UsuarioId);
            actividad.Property(p => p.FechaCreacion).HasColumnName("create_date");;
            actividad.Property(p => p.Descripcion).HasColumnName("actividad");;
        });
    }
}