using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Queries.Amities
{
    public class GetOneAmitieQuery : IQuery<Amitie>
    {
        public GetOneAmitieQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; init; }
    }
}
