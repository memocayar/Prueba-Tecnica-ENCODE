using API;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDbContext<APIContext>(p => p.UseInMemoryDatabase("APIDB"));

builder.Services.AddMySQLServer<APIContext>(builder.Configuration.GetConnectionString("cnDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconexion", async([FromServices] APIContext dbContext) => 
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.Run();
