using Axel_ReseauSocial.Api.Domains.Queries.Utilisateur;
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
    public class AmitieService : IAmitieRepository
    {
        private readonly ReseauSocialDbContext _context;

        public AmitieService(ReseauSocialDbContext context)
        {
            _context = context;
        }
        /*public IEnumerable<Amitie> Execute(GetAllUtilisateursQuery query)
        {
            return _context.Amities.Include(t => t.Travail).Include(r => r.Role).Include(l => l.Localite).ToList();
        }*/
    }
}
