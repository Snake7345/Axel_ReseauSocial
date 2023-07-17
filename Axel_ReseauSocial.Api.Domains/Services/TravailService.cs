using Axel_ReseauSocial.Api.Domains.Repositories;
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

    }
}
