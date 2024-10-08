using Application.Interfaces.Services;
using Application.Services;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Profiles;
using Domain.Services;
using Infra.Context;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<StoreDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAutoMapper(typeof(ProdutoProfile));

ConfigureServices(builder.Services);

builder.Services.AddControllers().AddNewtonsoftJson();
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

void ConfigureServices(IServiceCollection services)
{
    services.AddScoped<IProdutoAppService, ProdutoAppService>();
    services.AddScoped<IPedidoAppService, PedidoAppService>();

    services.AddScoped<IProdutoService, ProdutoService>();
    services.AddScoped<IPedidoService, PedidoService>();

    services.AddScoped<IProdutoRepository, ProdutoRepository>();
    services.AddScoped<IPedidoRepository, PedidoRepository>();
}