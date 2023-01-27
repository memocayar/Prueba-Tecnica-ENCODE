using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EncodeApp.Models;

public partial class DbPruebaTecnicaContext : DbContext
{
    public DbPruebaTecnicaContext()
    {
    }

    public DbPruebaTecnicaContext(DbContextOptions<DbPruebaTecnicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividad> Actividades { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.HasKey(e => e.IdActividad).HasName("PRIMARY");

            entity.ToTable("actividades");

            entity.HasIndex(e => e.IdActividad, "id_actividad_UNIQUE").IsUnique();

            entity.HasIndex(e => e.IdUsuario, "id_usuario_idx");

            entity.Property(e => e.IdActividad).HasColumnName("id_actividad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("actividad");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Actividades)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("id_usuario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.IdUsuario, "id_usuario_UNIQUE").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Alta).HasColumnName("alta");
            entity.Property(e => e.Apellido)
                .HasMaxLength(45)
                .HasColumnName("apellido");
            entity.Property(e => e.Contacto).HasColumnName("contacto");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(45)
                .HasColumnName("correo_electronico");
            entity.Property(e => e.FechaNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .HasColumnName("nombre");
            entity.Property(e => e.Pais)
                .HasMaxLength(45)
                .HasColumnName("pais");
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .HasColumnName("telefono");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
