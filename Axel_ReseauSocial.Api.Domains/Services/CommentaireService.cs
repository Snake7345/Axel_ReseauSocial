using Axel_ReseauSocial.Api.Domains.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Services
{
    public class CommentaireService : ICommentaireRepository
    {
        private readonly ReseauSocialDbContext _context;

        public CommentaireService(ReseauSocialDbContext context)
        {
            _context = context;
        }
    }
}
