using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs
{
    public class GetUtilisateurByEmailAndPasswordQuery : IQuery<Utilisateur>
    {
        public GetUtilisateurByEmailAndPasswordQuery(string email, string passwd)
        {
            Email = email;
            Passwd = passwd;
        }

        public string Email { get; }
        public string Passwd { get; }
    }
}
