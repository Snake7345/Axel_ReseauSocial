﻿using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Amities
{
    public class CreateAmitieCommand : ICommand
    {
        public bool? Attente { get; set; }
        public Guid DestinataireId { get; set; }
        public Guid DestinateurId { get; set; }

        public CreateAmitieCommand(bool? attente, Guid destinataireId, Guid destinateurId)
        {
            Attente = attente;
            DestinataireId = destinataireId;
            DestinateurId = destinateurId;
        }
    }
}
