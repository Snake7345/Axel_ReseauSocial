﻿using Axel_ReseauSocial.Api.Domains.Commands.Commentaires;
using Axel_ReseauSocial.Api.Domains.Commands.Pvs;
using Axel_ReseauSocial.Api.Domains.Queries.Commentaires;
using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class CommentaireService : ICommentaireRepository
    {
        private readonly ReseauSocialDbContext _context;

        public CommentaireService(ReseauSocialDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Commentaire> Execute(GetAllCommentairesQuery query)
        {
            return _context.Commentaires.ToList();
        }

        public Commentaire? Execute(GetOneCommentaireQuery query)
        {
            var comm = _context.Commentaires
                .FirstOrDefault(c => c.IdCommentaire == query.Id);

            return comm;
        }

        public Result Execute(CreateCommentaireCommand command)
        {
            try
            {
                Commentaire ObjectCommentaire = new Commentaire()
                {
                    PublicationId = command.PublicationId
                };
                _context.Commentaires.Add(ObjectCommentaire);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Commentaire)} a echouée");
            }

        }
    }
}
