﻿using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Dtos
{
    public class PvDto
    {
         public Guid IdPv { get; set; }

         public DateTime DateCreation { get; set; }

         public string Texte { get; set; }
         public UtilisateurDto Destinataire { get; set; }
         public UtilisateurDto Destinateur { get; set; }
    }
}
