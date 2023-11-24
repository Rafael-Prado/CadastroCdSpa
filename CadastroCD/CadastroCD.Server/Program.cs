using CadastroCD.Server.AutoMapper;
using Cd.Domain.Repositories.Interface;
using Cd.Domain.Service;
using Cd.Domain.Service.Interface;
using Cd.Repository.EFCoreInMemory.Models;
using Cd.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("TesteCD"));

builder.Services.AddTransient<ICdRepository, CdRepository>();
builder.Services.AddTransient<ICdService, CdService>();

builder.Services.AddTransient<IMusicaRepository, MusicaRepository>();
builder.Services.AddTransient<IMusicaService, MusicaService>();

builder.Services.AddAutoMapper(typeof(ConfigurationMapping));


var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
