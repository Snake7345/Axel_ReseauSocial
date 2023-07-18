using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Queries.Commentaires
{
    public class GetOneCommentaireQuery : IQuery<Commentaire>
    {
        public GetOneCommentaireQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; init; }
    }
}
