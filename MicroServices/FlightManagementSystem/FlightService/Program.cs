
using FlightService.Data;
using FlightService.Repository;
using FlightService.Service;
using Microsoft.EntityFrameworkCore;

namespace FlightService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<FlightDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlightConnection")));

            builder.Services.AddScoped<IFlightRepository, FlightRepository>();
            builder.Services.AddScoped<IFlightService, FlightService.Service.FlightService>();
            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
           // builder.Services.AddOpenApi();
          

            builder.Services.AddAutoMapper(cts=> { },AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
               // app.MapOpenApi();

                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
