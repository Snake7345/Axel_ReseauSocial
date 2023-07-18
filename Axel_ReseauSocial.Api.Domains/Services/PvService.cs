using Axel_ReseauSocial.Api.Domains.Commands.Pvs;
using Axel_ReseauSocial.Api.Domains.Commands.Travails;
using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
using Axel_ReseauSocial.Api.Domains.Queries.Roles;
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

        public Result Execute(CreatePvCommand command)
        {
            try
            {
                Pv ObjectPv = new Pv()
                {
                    DestinataireId = command.DestinataireId,
                    DestinateurId = command.DestinateurId,
                };
                _context.Pvs.Add(ObjectPv);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Pv)} a echouée");
            }

        }
    }
}
