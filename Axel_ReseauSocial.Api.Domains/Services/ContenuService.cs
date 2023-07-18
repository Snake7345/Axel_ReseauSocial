using Axel_ReseauSocial.Api.Domains.Commands.Contenus;
using Axel_ReseauSocial.Api.Domains.Commands.Travails;
using Axel_ReseauSocial.Api.Domains.Queries.Contenus;
using Axel_ReseauSocial.Api.Domains.Queries.Travails;
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
    public class ContenuService : IContenuRepository
    {
        private readonly ReseauSocialDbContext _context;

        public ContenuService(ReseauSocialDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Contenu> Execute(GetAllContenusQuery query)
        {
            return _context.Contenus.ToList();
        }

        public Contenu? Execute(GetOneContenuQuery query)
        {
            var contenu = _context.Contenus
                .FirstOrDefault(t => t.IdContenu == query.Id);

            return contenu;
        }
        public Result Execute(CreateContenuCommand command)
        {
            try
            {
                Contenu ObjectContenu = new Contenu()
                {
                    Texte = command.Texte,
                };
                _context.Contenus.Add(ObjectContenu);

                _context.SaveChanges();
                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure($"L\'insertion de l\'entité {nameof(Contenu)} a echouée");
            }

        }
    }
}
