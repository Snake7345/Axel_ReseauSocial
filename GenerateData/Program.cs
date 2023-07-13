using Axel_ReseauSocial.Api.Domains;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Globalization;
using System.Text.Json;

namespace GenerateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ReseauSocialDbContext dbContext = new ReseauSocialDbContext();

            #region Ajout des localités
            using TextReader textReader = File.OpenText(@"c:\Data\code-postaux-belge.csv");

            // Eliminer la ligne titre
            textReader.ReadLine();

            var localites = new List<Localite>();

            string? values;
            while ((values = textReader.ReadLine()) is not null)
            {
                string[] infos = values.Split(';');
                Localite localite = new Localite()
                {
                    CP = int.Parse(infos[0]),
                    Ville = infos[1],
                    Longitude = double.Parse(infos[2], GetNumberFormatInfo()),
                    Latitude = double.Parse(infos[3], GetNumberFormatInfo())
                };

                localites.Add(localite);
            }

            localites = localites.OrderBy(l => l.CP).ToList();

            dbContext.Localites.AddRange(localites);
            dbContext.SaveChanges();
            #endregion

            #region AddAdmin
            Role userRole = dbContext.Roles.First(r => r.Denomination == "Admin");
            Localite userLocalite = dbContext.Localites.First(l => l.Ville == "Jumet");
            Travail userTravail = dbContext.Travail.First(t => t.Denomination == "Programmeur Web");

            Utilisateur utilisateur = new Utilisateur()
            {
                Nom = "Bauduin",
                Prenom = "Axel",
                Email = "axel.bauduin@gmail.com",
                Passwd = "Test1234=",
                Sexe = "Masculin",
                Date = DateTime.Now,
                Localite = userLocalite,
                Role = userRole,
                Travail = userTravail,
            };

            dbContext.Add(utilisateur);
            dbContext.SaveChanges();
            #endregion
        }

        private static NumberFormatInfo GetNumberFormatInfo()
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
            numberFormatInfo.NumberDecimalSeparator = ",";
            return numberFormatInfo;
        }
    }
}