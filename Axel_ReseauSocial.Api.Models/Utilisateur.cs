using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Models
{
    public class Utilisateur
    {
        public Guid IdUtilisateur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string? Passwd { get; set; }
        public string Sexe { get; set; }
        public DateTime Date { get; set; }
        public bool Actif { get; set; }
        public int RoleId { get; set; }
        public int LocaliteId { get; set; }

        // Propriétés de navigations
        public virtual Role Role { get; set; }
        public virtual Localite Localite { get; set; }
    }
}
