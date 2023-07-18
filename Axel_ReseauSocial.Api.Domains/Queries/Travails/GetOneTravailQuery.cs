using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Queries.Travails
{
    public class GetOneTravailQuery : IQuery<Travail>
    {
        public GetOneTravailQuery(int id)
        {
            Id = id;
        }

        public int Id { get; init; }
    }
}