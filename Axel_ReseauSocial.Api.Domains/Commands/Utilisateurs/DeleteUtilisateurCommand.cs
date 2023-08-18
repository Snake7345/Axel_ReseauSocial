using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs
{
    public class DeleteUtilisateurCommand : ICommand
    {
        public Guid IdUtilisateur { get; init; }

        public DeleteUtilisateurCommand(Guid idUtilisateur)
        {
            IdUtilisateur = idUtilisateur;
        }

        


    }
}
