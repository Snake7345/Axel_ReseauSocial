using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Queries.Publications
{
    public class GetOnePublicationQuery : IQuery<Publication>
    {
        public GetOnePublicationQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; init; }
    }
}
