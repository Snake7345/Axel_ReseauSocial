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
    }
}
