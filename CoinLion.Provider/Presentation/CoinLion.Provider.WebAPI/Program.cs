using CoinLion.Provider.Application.Interfaces.Persistence;
using CoinLion.Provider.Application.UseCases.Queries;
using CoinLion.Provider.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IGetFruits, GetFruits>();
builder.Services.AddScoped<IFruitRepository, FruitRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
