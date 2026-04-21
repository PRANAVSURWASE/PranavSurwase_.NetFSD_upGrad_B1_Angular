
using Microsoft.EntityFrameworkCore;
using PassengerService.Data;

namespace PassengerService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<PassengerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PassengerConnection")));

            builder.Services.AddAutoMapper(cts=> { },AppDomain.CurrentDomain.GetAssemblies());

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
        

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }
           

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
