using Microsoft.EntityFrameworkCore;
using rent_car_api.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using rent_car_api.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Connection string
builder.Services.AddDbContext<RentCarDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// CORS settings
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder
            .AllowAnyOrigin() // Tüm kökenlere izin ver
            //.WithOrigins("https://localhost:3000")
            .AllowAnyMethod() // Tüm HTTP yöntemlerine izin ver
            .AllowAnyHeader()); // Tüm başlıklara izin ver
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AutoMapper added
builder.Services.AddAutoMapper(typeof(MappingCar).Assembly);


var app = builder.Build();

// Configure the HTTP request pipeline.
/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}*/

// CORS politikasını uygula
app.UseCors("AllowAllOrigins");

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
});

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

