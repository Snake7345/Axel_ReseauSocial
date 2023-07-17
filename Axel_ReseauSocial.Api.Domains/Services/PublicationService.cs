using Axel_ReseauSocial.Api.Domains.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class PublicationService : IPublicationRepository
    {
        private readonly ReseauSocialDbContext _context;

        public PublicationService(ReseauSocialDbContext context)
        {
            _context = context;
        }
    }
}
