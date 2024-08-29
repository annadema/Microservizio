
using BL.Libreria;
using DAL.Libreria;
using Interfaccia_DAL.Libreria;
using Interfaccia_BL.Libreria;

using BL.Angular;
using DAL.Angular;
using DAL.Data;
using Interfaccia_BL.Angular;
using Interfaccia_DAL.Angular;
using Microsoft.EntityFrameworkCore;

namespace Microservizio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Recupera la connection string dal file appsettings.json
            String? connectionStrings = builder.Configuration.GetConnectionString("DefaultConnection");

            // Configura il nostro Application DB Context con la connessione verso il DB
            builder.Services.AddDbContext<ApplicationDbContext>(options => {
                options.UseMySql(connectionStrings, ServerVersion.AutoDetect(connectionStrings));
            });

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddTransient<ILibreriaBL, LibreriaBL>();
            builder.Services.AddTransient<ILibreriaDAL, LibreriaDAL_Fake>();

            builder.Services.AddTransient<IAngularBL, AngularBL>();
            builder.Services.AddTransient<IAngularDAL, AngularDAL_Fake>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
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
        }
    }
}
