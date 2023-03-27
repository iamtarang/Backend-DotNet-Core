global using Backend.Services.CharacterService;
global using Backend.Models;
global using Backend.DTOs.Character;
global using AutoMapper;
global using Microsoft.EntityFrameworkCore;
global using Backend.Data;

var builder = WebApplication.CreateBuilder(args);

//String Connection
//UseSqlServer error fixed by 
//* dotnet add package Microsoft.EntityframeWorkCore.SqlServer

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<ICharacterService, CharacterService>();

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
