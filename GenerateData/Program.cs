using Axel_ReseauSocial.Api.Domains;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Globalization;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace GenerateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ReseauSocialDbContext dbContext = new ReseauSocialDbContext();

            #region Ajout des localités
            using TextReader textReader = File.OpenText(@"\Data\code-postaux-belge2.csv");

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

            #region Ajout des travaux

            string filePath = "c:\\Data\\ROME_ArboPrincipale.csv";

            using (TextReader textReader2 = new StreamReader(filePath, Encoding.GetEncoding("Windows-1252")))
            {
                List<Travail> travaux = new List<Travail>();

                string line;
                while ((line = textReader2.ReadLine()) is not null)
                {
                    string denomination = line.Trim(); // Supprimer les espaces en début et fin de ligne

                    if (!string.IsNullOrEmpty(denomination))
                    {
                        Travail travail = new Travail { Denomination = denomination };
                        travaux.Add(travail);
                    }
                }

                travaux.Sort((x, y) => string.Compare(x.Denomination, y.Denomination, StringComparison.OrdinalIgnoreCase));

                dbContext.Travails.AddRange(travaux);
                dbContext.SaveChanges();
            }
            #endregion

            #region AddAdmin
            Role userRole = dbContext.Roles.First(r => r.Denomination == "Admin");
            Localite userLocalite = dbContext.Localites.First(l => l.Ville == "Jumet");
            Travail userTravail = dbContext.Travails.First(t => t.Denomination == "Sans emploi");

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