using Microsoft.EntityFrameworkCore;
using WebAppSat.Models;

namespace WebAppSat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            

            builder.Services.AddDbContext<ProContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("constring")));

            builder.Services.AddControllers(); 

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IProduct, ProductService>();

            var app = builder.Build();

            // ✅ Middleware

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            

            app.Run();
        }
    }
}