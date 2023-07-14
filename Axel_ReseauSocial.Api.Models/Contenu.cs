using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Models
{
    public class Contenu
    {
        public Guid IdContenu { get; set; }
        public string Texte { get; set; }
        public DateTime DateCreation { get; set; }
        public Guid CommentaireId { get; set; }
        public Guid PublicationId { get; set; }
        public Guid PvId { get; set; }

        // Propriétés de navigations
        public virtual Commentaire Commentaire { get; set; }
        public virtual Publication Publication { get; set; }
        public virtual Pv Pv { get; set; }

    }
}
