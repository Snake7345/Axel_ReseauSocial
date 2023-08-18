using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Commentaires
{
    public class DeleteCommentaireCommand : ICommand
    {
        public Guid IdCommentaire { get; init; }

        public DeleteCommentaireCommand(Guid idCommentaire)
        {
            IdCommentaire = idCommentaire;
        }
    }
}
