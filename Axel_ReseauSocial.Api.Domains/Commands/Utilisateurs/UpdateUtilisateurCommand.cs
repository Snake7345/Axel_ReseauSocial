using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs
{
    public class UpdateUtilisateurCommand : ICommand
    {
            public Guid IdUtilisateur { get; init; }
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public string Email { get; set; }
            public string? Passwd { get; set; }
            public string Sexe { get; set; }
            public int RoleId { get; set; }
            public int LocaliteId { get; set; }
            public int TravailId { get; set; }

            public UpdateUtilisateurCommand(Guid idUtilisateur,string nom, string prenom, string email, string? passwd, string sexe, int roleId, int localiteId, int travailId)
            {
                IdUtilisateur = idUtilisateur;
                Nom = nom;
                Prenom = prenom;
                Email = email;
                Passwd = passwd;
                Sexe = sexe;
                RoleId = roleId;
                LocaliteId = localiteId;
                TravailId = travailId;
            }
    }
}
