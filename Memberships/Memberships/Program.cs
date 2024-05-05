using FluentValidation;
using Memberships.DTOs.Membership;
using Memberships.DTOs.MembershipByUser;
using Memberships.DTOs.MembershipStatus;
using Memberships.DTOs.Permission;
using Memberships.DTOs.PermissionByUser;
using Memberships.DTOs.User;
using Memberships.Models;
using Memberships.Security;
using Memberships.Validations.Membership;
using Memberships.Validations.MembershipByUser;
using Memberships.Validations.PermissionByUser;
using Memberships.Validations.User;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Context
builder.Services.AddDbContext<MemberSecurityContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MembershipConnection")));

//Validadores
builder.Services.AddScoped<IValidator<InsertMembershipDto>, InsertMembershipValidator>();
builder.Services.AddScoped<IValidator<UpdateMembershipDto>, UpdateMembershipValidator>();
builder.Services.AddScoped<IValidator<MembershipByUserDto>, MembershipByUserValidator>();
builder.Services.AddScoped<IValidator<PermissionByUserDto>, PermissionByUserValidator>();
builder.Services.AddScoped<IValidator<InsertUserDto>, InsertUserValidator>();
builder.Services.AddScoped<IValidator<UpdateUserDto>, UpdateUserValidator>();

//Password Hasher
builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();


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
