﻿using Axel_ReseauSocial.Api.Domains.Commands.Amities;
using Axel_ReseauSocial.Api.Domains.Commands.Contenus;
using Axel_ReseauSocial.Api.Domains.Queries.Amities;
using Axel_ReseauSocial.Api.Domains.Queries.Contenus;
using Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class AmitieService : IAmitieRepository
    {
        private readonly ReseauSocialDbContext _context;

        public AmitieService(ReseauSocialDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Amitie> Execute(GetAllAmitiesQuery query)
        {
            return _context.Amities.ToList();
        }

        public Amitie? Execute(GetOneAmitieQuery query)
        {
            var amitie = _context.Amities
                .FirstOrDefault(a => a.IdAmitie == query.Id);

            return amitie;
        }
        public Result Execute(CreateAmitieCommand command)
        {
            try
            {
                Amitie ObjectAmitie = new Amitie()
                {
                    Accepte = command.Accepte,
                    Refuse = command.Refuse,
                    Attente = command.Attente,
                    DestinataireId = command.DestinataireId,
                    DestinateurId = command.DestinateurId,
                };
                _context.Amities.Add(ObjectAmitie);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Amitie)} a echouée");
            }

        }
    }
}
