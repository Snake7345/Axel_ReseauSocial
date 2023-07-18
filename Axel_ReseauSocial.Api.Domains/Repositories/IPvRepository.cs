using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
using Axel_ReseauSocial.Api.Domains.Queries.Roles;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Repositories
{
    public interface IPvRepository : IQueryHandler<GetAllPvsQuery, IEnumerable<Pv>>,
        IQueryHandler<GetOnePvQuery, Pv?>
    {
    }
}
