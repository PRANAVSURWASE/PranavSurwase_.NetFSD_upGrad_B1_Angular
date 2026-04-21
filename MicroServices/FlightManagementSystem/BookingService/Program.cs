
using BookingService.Data;
using BookingService.Repository;
using BookingService.Service;
using Microsoft.EntityFrameworkCore;

namespace BookingService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<BookingDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("BookingConnection")));
            builder.Services.AddAutoMapper(cts=> { },AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddScoped<IBookingRepository, BookingRepository>();
            builder.Services.AddScoped<IBookingService, BookingService.Service.BookingService>();

            builder.Services.AddHttpClient();
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
           // builder.Services.AddOpenApi();

           


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI();
            }
         

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
