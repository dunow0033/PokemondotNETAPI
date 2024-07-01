using Microsoft.EntityFrameworkCore;
using PokemonAPI.Database;
using PokemonAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PokemonContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PokemonApi") ?? throw new InvalidOperationException("Connection String not found")));

builder.Services.AddScoped<IPokemonRepository, PokemonRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //using var scope = app.Services.CreateScope();
    //SeedDatabase.Seed(scope.ServiceProvider.GetRequiredService<PokemonContext>());
}

app.UseCors(options =>
    options.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
