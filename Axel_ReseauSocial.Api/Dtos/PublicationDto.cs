﻿using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Dtos
{
    public class PublicationDto
    {
            public Guid IdPublication { get; set; }
            public UtilisateurDto Utilisateur { get; set; }
    }
}