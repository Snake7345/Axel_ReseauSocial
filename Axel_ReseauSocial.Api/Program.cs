using Axel_ReseauSocial.Api.Domains;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Domains.Services;

namespace Axel_ReseauSocial.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ReseauSocialDbContext>();
            builder.Services.AddScoped<IUtilisateurRepository,UtilisateurService>();
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

            app.UseCors("AllowAll"); // Add this line to enable CORS

            app.MapControllers();

            app.Run();
        }
    }
}