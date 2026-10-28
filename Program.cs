using GestionProductosWebAPI.Repositories;
using GestionProductosWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Registrar controladores y dependencias de las 3 capas
builder.Services.AddControllers();
builder.Services.AddScoped<IProductoRepository, ProductoRepository>();
builder.Services.AddScoped<IProductoService, ProductoService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();