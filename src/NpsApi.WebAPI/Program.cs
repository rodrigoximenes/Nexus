using Microsoft.EntityFrameworkCore;
using NpsApi.Repositorio.Interfaces;
using NpsApi.Repositorio;
using NpsApi.Servico.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configuração do banco de dados (PostgreSQL)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configuração de repositórios e serviços
builder.Services.AddScoped<IRevisaoRepositorio, RevisaoRepositorio>();
builder.Services.AddScoped<IRevisaoServico, RevisaoServico>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
