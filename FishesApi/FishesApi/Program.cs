using FishesApi.DTOs.Fishes;
using FishesApi.Models;
using FishesApi.Validators;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Entity

builder.Services.AddDbContext<FishContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FishesContext"));
});

//Validators
builder.Services.AddScoped<IValidator<FishInsertDto>, FishValidation>();

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
