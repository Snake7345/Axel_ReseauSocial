using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Models
{
    public class Commentaire
    {
        public Guid IdCommentaire { get; set; }
        public Guid UtilisateurId { get; set; }
        public Guid PublicationId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Publication Publication { get; set; }
    }
}
