using API.models;
using Microsoft.EntityFrameworkCore;

namespace API;

public class APIContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Actividad> Actividad { get; set; }

    public APIContext(DbContextOptions<APIContext> options) : base(options) { }
}