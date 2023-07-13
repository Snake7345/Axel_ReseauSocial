using Axel_ReseauSocial.Api.Domains.Configurations;
using Axel_ReseauSocial.Api.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;

namespace Axel_ReseauSocial.Api.Domains
{
    public class ReseauSocialDbContext : DbContext
    {
        public DbSet<Localite> Localites { get { return Set<Localite>(); } }
        public DbSet<Role> Roles { get { return Set<Role>(); } }
        public DbSet<Travail> Travail { get { return Set<Travail>(); } }
        public DbSet<Utilisateur> Utilisateurs { get { return Set<Utilisateur>(); } }

        public ReseauSocialDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PC-AXEL;Initial Catalog=DB_RS;Integrated Security=True");
            optionsBuilder.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information).EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocaliteConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new TravailConfig());
            modelBuilder.ApplyConfiguration(new UtilisateurConfig());
        }

        //Constructeur appelé par l'injection de dépendence de l'api
        //public ReseauSocialDbContext(DbContextOptions<ReseauSocialDbContext> options) : base(options)
        //{
        //}
    }
}