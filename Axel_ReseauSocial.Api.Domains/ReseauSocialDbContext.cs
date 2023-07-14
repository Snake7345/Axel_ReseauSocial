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
        public DbSet<Pv> Pvs { get { return Set<Pv>(); } }
        public DbSet<Amitie> Amities { get { return Set<Amitie>(); } }
        public DbSet<Publication> Publications { get { return Set<Publication>(); } }
        public DbSet<Commentaire> Commentaires { get { return Set<Commentaire>(); } }
        public DbSet<Contenu> Contenus { get { return Set<Contenu>(); } }

        public ReseauSocialDbContext()
        {

        }

        //Constructeur appelé par l'injection de dépendence de l'api
        public ReseauSocialDbContext(DbContextOptions<ReseauSocialDbContext> options) : base(options)
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
            modelBuilder.ApplyConfiguration(new PvConfig());
            modelBuilder.ApplyConfiguration(new AmitieConfig());
            modelBuilder.ApplyConfiguration(new PublicationConfig());
            modelBuilder.ApplyConfiguration(new CommentaireConfig());
            modelBuilder.ApplyConfiguration(new ContenuConfig());
        }


    }
}