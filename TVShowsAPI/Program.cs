using Autofac.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using TVShowsAPI.Infrastructure.Data;
using TVShowsAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Iniciacion de Entity Framework con una base de datos en memoria
builder.Services.AddDbContext<TvShowContext>(options =>
     options.UseInMemoryDatabase("TvShowsDb"));

/*Añadir biblioteca para el patron Mediator*/
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

/*Añadir biblioteca para el uso de mapeo de objetos*/
builder.Services.AddAutoMapper(typeof(Program));

//Inyeccion de dependencias
builder.Services.AddScoped<ITvShowRepository, TvShowRepository>();

//Configuracion de swagger en caso de modo debug
builder.Services.AddEndpointsApiExplorer();
/*Agrega la documentacion*/
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "TV Shows API - Code Challenge", Version = "v1" });

    // Ruta a tu archivo de comentarios XML
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Inicializa la base de datos con datos precargados
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<TvShowContext>();
    context.Database.EnsureDeleted(); // Elimina la base de datos en memoria
    context.Database.EnsureCreated(); // Crea la base de datos y aplica los datos precargados
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
