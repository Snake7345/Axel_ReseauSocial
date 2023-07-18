using Axel_ReseauSocial.Api.Domains.Queries.Publications;
using Axel_ReseauSocial.Api.Domains.Queries.Pvs;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Repositories
{
    public interface IPublicationRepository : IQueryHandler<GetAllPublicationsQuery, IEnumerable<Publication>>,
        IQueryHandler<GetOnePublicationQuery, Publication?>
    {
    }
}
