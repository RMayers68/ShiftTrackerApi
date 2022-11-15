using Microsoft.EntityFrameworkCore;
using ShiftTrackerApi.Models;
using System.Configuration;

Console.WriteLine(System.Configuration.ConfigurationManager.ConnectionStrings["DbPath"].ConnectionString);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ShiftContext>(opt =>
    opt.UseSqlServer(System.Configuration.ConfigurationManager.ConnectionStrings["DbPath"].ConnectionString));
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
