using Axel_ReseauSocial.Api.Domains.Commands.Pvs;
using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
using Axel_ReseauSocial.Api.Domains.Repositories;
using Axel_ReseauSocial.Api.Models;
using Microsoft.EntityFrameworkCore;
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
            return _context.Pvs.Include(destinataire=>destinataire.Destinataire)
                .Include(destinateur => destinateur.Destinateur).ToList();
        }

        public Pv? Execute(GetOnePvQuery query)
        {
            var pv = _context.Pvs.Include(destinataire => destinataire.Destinataire)
                .Include(destinateur => destinateur.Destinateur)
                .FirstOrDefault(p => p.IdPv == query.Id);

            return pv;
        }

        public Result Execute(CreatePvCommand command)
        {
            try
            {
                Pv ObjectPv = new Pv()
                {
                    DateCreation = DateTime.Now,
                    Texte = command.Texte,
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
