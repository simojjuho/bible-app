using Infrastructure.Database.Models;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddCustomSwagger();

// Add Database:
var dbDataSource = new NpgsqlDataSourceBuilder(builder.Configuration.GetConnectionString("DefaultConnection"))
    .Build();
/*builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseNpgsql(dbDataSource);
});*/

var app = builder.Build();

app.MapGet("/welcome", () => "Hello World!");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();