using Axel_ReseauSocial.Api.Domains.Queries.Localites;
using Axel_ReseauSocial.Api.Domains.Queries.Travails;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class LocaliteService : ILocaliteRepository
    {
        private readonly ReseauSocialDbContext _context;

        public LocaliteService(ReseauSocialDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Localite> Execute(GetAllLocalitesQuery query)
        {
            return _context.Localites.ToList();
        }

        public Localite? Execute(GetOneLocaliteQuery query)
        {
            var localite = _context.Localites
                .FirstOrDefault(l => l.IdLocalite == query.Id);

            return localite;
        }


    }
}
