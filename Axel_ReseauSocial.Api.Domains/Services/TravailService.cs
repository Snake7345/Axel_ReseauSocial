using Axel_ReseauSocial.Api.Domains.Commands.Travails;
using Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Queries.Travails;
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
    public class TravailService : ITravailRepository
    {
        private readonly ReseauSocialDbContext _context;

        public TravailService(ReseauSocialDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Travail> Execute(GetAllTravailsQuery query)
        {
            return _context.Travails.ToList();
        }

        public Travail? Execute(GetOneTravailQuery query)
        {
            var travail = _context.Travails
                .FirstOrDefault(t => t.IdTravail == query.Id);

            return travail;
        }
        public Result Execute(CreateTravailCommand command)
        {
            try
            {
                Travail ObjectTravail = new Travail()
                {
                    Denomination = command.Denomination,
                };
                _context.Travails.Add(ObjectTravail);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Travail)} a echouée");
            }

        }
    }
}
