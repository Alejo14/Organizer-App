using api.Data;
using api.Services.Implementations;
using api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// CORS
builder.Services.AddCors(options =>
  options.AddPolicy("AllowFrontEnd",
    policy => policy.WithOrigins("http://localhost:5173")
      .AllowAnyHeader()
      .AllowAnyMethod()
    )
);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add DB Context
var connectionString = builder.Configuration.GetConnectionString("PostgreSQL");

builder.Services.AddDbContext<ToDoAppDBContext>(options =>
  options.UseNpgsql(connectionString)
);

// Adding Services (DI)
builder.Services.AddScoped<IBucketService, BucketService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseCors("AllowFrontEnd");

app.UseHttpsRedirection();

app.UseAuthentication();

app.MapControllers();

// Start the backend
app.Run();
