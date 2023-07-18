using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
using Axel_ReseauSocial.Api.Domains.Queries.Roles;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class PvService : IPvRepository
    {
        private readonly ReseauSocialDbContext _context;

        public PvService(ReseauSocialDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pv> Execute(GetAllPvsQuery query)
        {
            return _context.Pvs.ToList();
        }

        public Pv? Execute(GetOnePvQuery query)
        {
            var pv = _context.Pvs
                .FirstOrDefault(p => p.IdPv == query.Id);

            return pv;
        }
    }
}
