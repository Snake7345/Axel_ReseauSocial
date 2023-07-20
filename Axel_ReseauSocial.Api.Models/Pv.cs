using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Models
{
    public class Pv
    {
        public Guid IdPv { get; set; }


        public DateTime DateCreation { get; set; }

        public string Texte { get; set; }

        public Guid DestinataireId { get; set; }
        public Guid DestinateurId { get; set; }

        // Propriétés de navigations
        public virtual Utilisateur Destinataire { get; set; }
        public virtual Utilisateur Destinateur { get; set; }
    }
}
