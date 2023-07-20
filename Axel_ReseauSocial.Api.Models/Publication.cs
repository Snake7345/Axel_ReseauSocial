using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Models
{
    public class Publication
    {
        public Guid IdPublication { get; set; }
        

        public DateTime DateCreation { get; set; }

        public string Texte { get; set; }

        public Guid UtilisateurId { get; set; }

        // Propriétés de navigations
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
