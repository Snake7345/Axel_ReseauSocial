using Axel_ReseauSocial.Api.Domains.Queries.Travails;
using Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Repositories
{
    public interface ITravailRepository : IQueryHandler<GetAllTravailsQuery, IEnumerable<Travail>>,
        IQueryHandler<GetOneTravailQuery, Travail?>
    {
    }
}
