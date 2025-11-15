using destino_quisqueya_back._0.DBontext;
using destino_quisqueya_core.SERVICE;
using destino_quisqueya_data.CONTRACT;
using destino_quisqueya_data.REPOSITORY;
using MEDICORE.CORE.INTERFACE;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();  //Swashbuckle.AspNetCore  NugPack

builder.Services.AddDbContext<AppDBContext>(opciones =>
opciones.UseSqlServer("name=DefaultConnection"));

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService, UserServices>();

builder.Services.AddTransient<IAuthRepository, AuthRepository>();
builder.Services.AddTransient<IAuthService, AuthServices>();

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
