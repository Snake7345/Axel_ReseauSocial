using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs
{
    public class GetSearchUtilisateurByNameQuery : IQuery<IEnumerable<Utilisateur>>
    {
        public string Nom { get; }

        public GetSearchUtilisateurByNameQuery(string nom)
        {
            Nom = nom;
        }
    }
}
