using DB;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AutenticacionUsuariosContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("UsersConnection"));
});

var app = builder.Build();
//Esto es para generar la base de datos, para crearla
//Comentar una vez creada. Para crearla correr el codigo
/*
using (var scope = app.Services.CreateScope()) 
{
    var context = scope.ServiceProvider.GetRequiredService<AutenticacionUsuariosContext>();
    context.Database.Migrate();
}
*/


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
